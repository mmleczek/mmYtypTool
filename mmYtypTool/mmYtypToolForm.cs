using CodeWalker.GameFiles;
using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mmYtypTool
{
    public partial class mmYtypToolForm : Form
    {
        private RpfManager RpfMan = null;
        YtypFile file = new YtypFile();
        string OpenedFilePath = "";

        string GTAV_exe_path;
        string GTAV_exe_key;

        public mmYtypToolForm()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
        }

        private void mmYtypTool_Shown(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void editModeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (editModeCb.Checked)
            {
                ytypNameTb.ReadOnly = false;
                archetypeTypeTb.ReadOnly = false;
                nameTb.ReadOnly = false;
                assetNameTb.ReadOnly = false;
                assetTypeCb.Enabled = true;

                textureDictTb.ReadOnly = false;
                physicsDictTb.ReadOnly = false;
                drawableDictTb.ReadOnly = false;

                specialAttributeCb.Enabled = true;
                flagsTb.ReadOnly = false;

                bbMinTb.ReadOnly = false;
                bbMaxTb.ReadOnly = false;
                bsCentreTb.ReadOnly = false;
                bsRadiusTb.ReadOnly = false;
                hdTextureDistTb.ReadOnly = false;
                lodDistTb.ReadOnly = false;

                archetypeTsBtn.Enabled = true;
                flagsCalcList.Enabled = true;
                clearFlagsBtn.Enabled = true;
            }
            else
            {
                ytypNameTb.ReadOnly = true;
                archetypeTypeTb.ReadOnly = true;
                nameTb.ReadOnly = true;
                assetNameTb.ReadOnly = true;
                assetTypeCb.Enabled = false;

                textureDictTb.ReadOnly = true;
                physicsDictTb.ReadOnly = true;
                drawableDictTb.ReadOnly = true;

                specialAttributeCb.Enabled = false;
                flagsTb.ReadOnly = true;

                bbMinTb.ReadOnly = true;
                bbMaxTb.ReadOnly = true;
                bsCentreTb.ReadOnly = true;
                bsRadiusTb.ReadOnly = true;
                hdTextureDistTb.ReadOnly = true;
                lodDistTb.ReadOnly = true;

                archetypeTsBtn.Enabled = false;
                flagsCalcList.Enabled = false;
                clearFlagsBtn.Enabled = false;
            }
        }

        #region toolbar
        private void loadYtypFileBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

                dlg.Title = "Choose Ytyp file to load";
                dlg.Multiselect = false;
                dlg.CheckFileExists = true;
                dlg.AddExtension = true;
                dlg.DefaultExt = ".ytyp";
                dlg.Filter = "Ytyp file|*.ytyp";

                bool? result = dlg.ShowDialog();
                if (result == true)
                {
                    OpenedFilePath = dlg.FileName;
                    byte[] file_raw = File.ReadAllBytes(dlg.FileName);
                    file.Load(file_raw);
                    loadingLb.Text = $"Loading {dlg.SafeFileName}";
                    ytypNameTb.Text = dlg.SafeFileName;
                    archeotypesCb.Items.Clear();

                    foreach (Archetype a in file.AllArchetypes)
                    {
                        archeotypesCb.Items.Add(a.Name);
                    }

                    archeotypesCb.SelectedIndex = 0;
                    loadingLb.Text = $"Loaded {dlg.SafeFileName}";
                    currFileLb.Text = dlg.SafeFileName;
                    CommitSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured: {ex.Message}");
            }
        }
        private void importYdrFileBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

                dlg.Title = "Choose Ydr files to import";
                dlg.Multiselect = true;
                dlg.CheckFileExists = true;
                dlg.AddExtension = true;
                dlg.DefaultExt = ".ydr";
                dlg.Filter = "Ydr file|*.ydr";

                bool? result = dlg.ShowDialog();
                if (result == true && dlg.FileNames.Length > 0)
                {
                    foreach(string path in dlg.FileNames)
                    {
                        YdrFile fileYdr = new YdrFile();
                        byte[] file_raw = File.ReadAllBytes(path);
                        RpfFile.LoadResourceFile<YdrFile>(fileYdr, file_raw, 165);
                        loadingLb.Text = $"Importing {dlg.SafeFileName}";
                        fileYdr.Drawable.Name = fileYdr.Drawable.Name.Replace(".#dr", "");

                        string name_hash = GetProperHash(Path.GetFileNameWithoutExtension(path)).ToString();

                        nameTb.Text = name_hash;
                        assetNameTb.Text = name_hash;
                        assetTypeCb.Text = "ASSET_TYPE_DRAWABLE";

                        textureDictTb.Text = fileYdr.Drawable.ShaderGroup.TextureDictionary == null ? "" : fileYdr.Drawable.Name;
                        physicsDictTb.Text = fileYdr.Drawable.Bound == null ? "" : fileYdr.Drawable.Name;
                        drawableDictTb.Text = "";

                        specialAttributeCb.SelectedIndex = 0;
                        flagsTb.Text = "32";

                        hdTextureDistTb.Text = "60.0";
                        lodDistTb.Text = "60.0";

                        bbMinTb.Text = $"{(decimal)fileYdr.Drawable.BoundingBoxMin.X}, {(decimal)fileYdr.Drawable.BoundingBoxMin.Y}, {(decimal)fileYdr.Drawable.BoundingBoxMin.Z}";
                        bbMaxTb.Text = $"{(decimal)fileYdr.Drawable.BoundingBoxMax.X}, {(decimal)fileYdr.Drawable.BoundingBoxMax.Y}, {(decimal)fileYdr.Drawable.BoundingBoxMax.Z}";
                        bsCentreTb.Text = $"{(decimal)fileYdr.Drawable.BoundingCenter.X}, {(decimal)fileYdr.Drawable.BoundingCenter.Y}, {(decimal)fileYdr.Drawable.BoundingCenter.Z}";
                        bsRadiusTb.Text = fileYdr.Drawable.BoundingSphereRadius.ToString();

                        loadingLb.Text = $"Imported {dlg.SafeFileName}";
                        currFileLb.Text = dlg.SafeFileName;

                        addArchetypeFromForms();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured: {ex.Message}");
            }
        }
        private void clearWorkspaceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                file = null;
                file = new YtypFile();
                ytypNameTb.Text = "";
                ClearTextboxes();
                OpenedFilePath = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured: {ex.Message}");
            }
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrEmpty(OpenedFilePath))
                {
                    if(File.Exists(OpenedFilePath))
                    {
                        if (!string.IsNullOrEmpty(ytypNameTb.Text))
                        {
                            file.Name = ytypNameTb.Text;
                            if (!file.Name.EndsWith(".ytyp"))
                            {
                                file.Name += ".ytyp";
                            }

                            File.WriteAllBytes($"{Path.GetDirectoryName(OpenedFilePath)}/{file.Name}", file.Save());
                            loadingLb.Text = $"Saved {file.Name}";
                        }
                        else
                        {
                            MessageBox.Show($"Set Ytyp name first!");
                        }
                    }
                    else
                    {
                        openSaveFileDialog();
                    }
                }
                else
                {
                    openSaveFileDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured: {ex.Message}");
            }
        }
        private void saveAsBtn_Click(object sender, EventArgs e)
        {
            openSaveFileDialog();
        }
        private void openSaveFileDialog()
        {
            try
            {
                if (!string.IsNullOrEmpty(ytypNameTb.Text))
                {
                    file.Name = ytypNameTb.Text;
                    if (!file.Name.EndsWith(".ytyp"))
                    {
                        file.Name += ".ytyp";
                    }

                    string name = file.Name.Replace(".ytyp", "");
                    JenkIndex.Ensure(name);
                    MetaHash namehash = new MetaHash(JenkHash.GenHash(name));
                    file._CMapTypes.name = namehash;
                    file.NameHash = namehash.Hash;

                    SaveFileDialog dlg = new SaveFileDialog();
                    dlg.Title = "Choose location where to save file";
                    dlg.DefaultExt = "ytyp";
                    dlg.Filter = "Ytyp file|*.ytyp";
                    dlg.CheckFileExists = false;
                    dlg.CheckPathExists = true;
                    dlg.RestoreDirectory = true;
                    dlg.ValidateNames = true;
                    dlg.SupportMultiDottedExtensions = false;
                    dlg.FileName = file.Name;
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        byte[] data = file.Save();
                        File.WriteAllBytes($"{dlg.FileName}", data);
                        loadingLb.Text = $"Saved {Path.GetFileName(dlg.FileName)}";
                    }
                }
                else
                {
                    MessageBox.Show($"Set Ytyp name first!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured while saving file 2. Error message: {ex.Message}");
            }
        }
        private void jenkinsHashBtn_Click(object sender, EventArgs e)
        {
            JenkinsHashForm jenkinsHashForm = new JenkinsHashForm();
            jenkinsHashForm.Show();
        }
        #endregion

        #region archeotype stuff
        private void archeotypesCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CommitSelection();
        }
        private void addBaseArchetypeBtn_Click(object sender, EventArgs e)
        {
            EnterNameForm getName = new EnterNameForm(new Action<string>((name) => {
                if(!string.IsNullOrEmpty(name))
                {
                    ClearTextboxes();
                    nameTb.Text = name.ToLowerInvariant();
                    assetNameTb.Text = name.ToLowerInvariant();
                    flagsTb.Text = "0";
                    addArchetypeFromForms();
                }
                else
                {
                    MessageBox.Show("Name cannot be empty.");
                }
            }));
            getName.Show();
        }
        private void addArchetypeFromForms()
        {
            try
            {
                Archetype s = new Archetype();
                
                s._BaseArchetypeDef.name = GetProperHash(nameTb.Text.ToLowerInvariant());
                s._BaseArchetypeDef.assetName = GetProperHash(assetNameTb.Text.ToLowerInvariant());

                s._BaseArchetypeDef.assetType = (rage__fwArchetypeDef__eAssetType)assetTypeCb.SelectedIndex;

                s._BaseArchetypeDef.textureDictionary = GetProperHash(textureDictTb.Text.ToLowerInvariant());
                s._BaseArchetypeDef.physicsDictionary = GetProperHash(physicsDictTb.Text.ToLowerInvariant());
                s._BaseArchetypeDef.drawableDictionary = GetProperHash(drawableDictTb.Text.ToLowerInvariant());

                s._BaseArchetypeDef.specialAttribute = Convert.ToUInt32(specialAttributeCb.SelectedIndex);
                s._BaseArchetypeDef.flags = Convert.ToUInt32(flagsTb.Text);

                if(!string.IsNullOrEmpty(bbMinTb.Text))
                {
                    string[] vals = bbMinTb.Text.Split(',');
                    s._BaseArchetypeDef.bbMin = new SharpDX.Vector3(Convert.ToSingle(vals[0]), Convert.ToSingle(vals[1]), Convert.ToSingle(vals[2]));
                }

                if (!string.IsNullOrEmpty(bbMaxTb.Text))
                {
                    string[] vals = bbMaxTb.Text.Split(',');
                    s._BaseArchetypeDef.bbMax = new SharpDX.Vector3(Convert.ToSingle(vals[0]), Convert.ToSingle(vals[1]), Convert.ToSingle(vals[2]));
                }

                if (!string.IsNullOrEmpty(bbMaxTb.Text))
                {
                    string[] vals = bsCentreTb.Text.Split(',');
                    s._BaseArchetypeDef.bsCentre = new SharpDX.Vector3(Convert.ToSingle(vals[0]), Convert.ToSingle(vals[1]), Convert.ToSingle(vals[2]));
                }

                if (!string.IsNullOrEmpty(bsRadiusTb.Text))
                {
                    s._BaseArchetypeDef.bsRadius = Convert.ToSingle(bsRadiusTb.Text);
                }

                if (!string.IsNullOrEmpty(hdTextureDistTb.Text))
                {
                    s._BaseArchetypeDef.hdTextureDist = Convert.ToSingle(hdTextureDistTb.Text);
                }

                if (!string.IsNullOrEmpty(lodDistTb.Text))
                {
                    s._BaseArchetypeDef.lodDist = Convert.ToSingle(lodDistTb.Text);
                }
                
                file.AddArchetype(s);

                archeotypesCb.Items.Add(s.Name);
                archeotypesCb.SelectedIndex = archeotypesCb.Items.Count - 1;
                CommitSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured while addArchetypeFromForms. Error message: {ex.Message}");
            }
        }
        private void removeCurrArcheBtn_Click(object sender, EventArgs e)
        {
            string name = archeotypesCb.Text;

            if (file.AllArchetypes[archeotypesCb.SelectedIndex] != null)
            {
                file.RemoveArchetype(file.AllArchetypes[archeotypesCb.SelectedIndex]);
                archeotypesCb.Items.RemoveAt(archeotypesCb.SelectedIndex);

                if (archeotypesCb.Items.Count > 0)
                {
                    archeotypesCb.SelectedIndex = archeotypesCb.Items.Count - 1;
                }
                else
                {
                    archetypeTypeTb.Text = "";
                    archeotypesCb.Text = "";
                    archeotypesCb.Items.Clear();
                    ytypNameTb.Text = "";
                    nameTb.Text = "";
                    assetNameTb.Text = "";
                    assetTypeCb.Text = "";
                    textureDictTb.Text = "";
                    physicsDictTb.Text = "";
                    drawableDictTb.Text = "";
                    specialAttributeCb.SelectedIndex = 0;
                    for (int i = 0; i < flagsCalcList.Items.Count; i++) flagsCalcList.SetItemChecked(i, false);
                    flagsTb.Text = "";
                    hdTextureDistTb.Text = "";
                    lodDistTb.Text = "";
                    bbMinTb.Text = "";
                    bbMaxTb.Text = "";
                    bsCentreTb.Text = "";
                    bsRadiusTb.Text = "";
                    loadingLb.Text = "";
                    currFileLb.Text = "";
                }

                CommitSelection();
                MessageBox.Show($"Removed {name} archetype");
            }
        }
        private void CommitSelection()
        {
            try
            {
                Archetype[] archs = file.AllArchetypes;
                if (archs.Length > archeotypesCb.SelectedIndex)
                {
                    Archetype selected = archs[archeotypesCb.SelectedIndex];

                    archetypeIndexLb.Text = $"Index: {archeotypesCb.SelectedIndex}";
                    archetypeTypeTb.Text = selected.Type.ToString();

                    nameTb.Text = selected.Name;
                    assetNameTb.Text = selected._BaseArchetypeDef.assetName.ToString();
                    assetTypeCb.Text = selected._BaseArchetypeDef.assetType.ToString();

                    textureDictTb.Text = selected._BaseArchetypeDef.textureDictionary.ToString();
                    physicsDictTb.Text = selected._BaseArchetypeDef.physicsDictionary.ToString();
                    drawableDictTb.Text = selected._BaseArchetypeDef.drawableDictionary.ToString();

                    specialAttributeCb.SelectedIndex = Convert.ToInt32(selected._BaseArchetypeDef.specialAttribute);
                    flagsTb.Text = selected._BaseArchetypeDef.flags.ToString();

                    bbMinTb.Text = $"{(decimal)selected._BaseArchetypeDef.bbMin.X}, {(decimal)selected._BaseArchetypeDef.bbMin.Y}, {(decimal)selected._BaseArchetypeDef.bbMin.Z}";
                    bbMaxTb.Text = $"{(decimal)selected._BaseArchetypeDef.bbMax.X}, {(decimal)selected._BaseArchetypeDef.bbMax.Y}, {(decimal)selected._BaseArchetypeDef.bbMax.Z}";
                    bsCentreTb.Text = $"{(decimal)selected._BaseArchetypeDef.bsCentre.X}, {(decimal)selected._BaseArchetypeDef.bsCentre.Y}, {(decimal)selected._BaseArchetypeDef.bsCentre.Z}";
                    bsRadiusTb.Text = selected._BaseArchetypeDef.bsRadius.ToString();
                    hdTextureDistTb.Text = selected._BaseArchetypeDef.hdTextureDist.ToString();
                    lodDistTb.Text = selected._BaseArchetypeDef.lodDist.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured: {ex.Message}");
            }
        }
        #endregion

        #region flags
        bool __flags_user_change = false;
        private void flagsTb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                __flags_user_change = true;
                uint flags = 0;
                uint.TryParse(flagsTb.Text, out flags);
                for (int i = 0; i < flagsCalcList.Items.Count; i++)
                {
                    var c = ((flags & (1u << i)) > 0);
                    flagsCalcList.SetItemCheckState(i, c ? CheckState.Checked : CheckState.Unchecked);
                }
                __flags_user_change = false;

                if (file.AllArchetypes != null)
                {
                    if (file.AllArchetypes[archeotypesCb.SelectedIndex] != null)
                    {
                        file.AllArchetypes[archeotypesCb.SelectedIndex]._BaseArchetypeDef.flags = Convert.ToUInt32(flagsTb.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured: {ex.Message}");
            }
        }
        private void flagsCalcList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            try
            {
                if (!__flags_user_change)
                {
                    uint flags = 0;
                    for (int i = 0; i < flagsCalcList.Items.Count; i++)
                    {
                        if (e.Index == i)
                        {
                            if (e.NewValue == CheckState.Checked) flags += (uint)(1 << i);
                        }
                        else
                        {
                            if (flagsCalcList.GetItemChecked(i)) flags += (uint)(1 << i);
                        }
                    }

                    flagsTb.Text = flags.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured: {ex.Message}");
            }
        }
        private void clearFlagsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < flagsCalcList.Items.Count; i++) flagsCalcList.SetItemChecked(i, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured: {ex.Message}");
            }
        }
        #endregion

        #region handle changes
        private void nameTb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (((TextBox)sender).Modified)
                    if (file.AllArchetypes != null)
                    {
                        if (file.AllArchetypes[archeotypesCb.SelectedIndex] != null)
                        {
                            archeotypesCb.Items[archeotypesCb.SelectedIndex] = nameTb.Text;
                            file.AllArchetypes[archeotypesCb.SelectedIndex]._BaseArchetypeDef.name = GetProperHash(nameTb.Text);
                        }
                    }
            }
            catch { }
        }
        private void assetNameTb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (((TextBox)sender).Modified)
                    if (file.AllArchetypes != null)
                    {
                        if (file.AllArchetypes[archeotypesCb.SelectedIndex] != null)
                        {
                            file.AllArchetypes[archeotypesCb.SelectedIndex]._BaseArchetypeDef.assetName = GetProperHash(assetNameTb.Text);
                        }
                    }
            }
            catch { }
        }
        private void assetTypeCb_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (file.AllArchetypes != null)
                {
                    if (file.AllArchetypes[archeotypesCb.SelectedIndex] != null)
                    {
                        file.AllArchetypes[archeotypesCb.SelectedIndex]._BaseArchetypeDef.assetType = (rage__fwArchetypeDef__eAssetType)assetTypeCb.SelectedIndex;
                    }
                }
            }
            catch { }
        }
        private void textureDictTb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (((TextBox)sender).Modified)
                    if (file.AllArchetypes != null)
                    {
                        if (file.AllArchetypes[archeotypesCb.SelectedIndex] != null)
                        {
                            file.AllArchetypes[archeotypesCb.SelectedIndex]._BaseArchetypeDef.textureDictionary = JenkHash.GenHash(textureDictTb.Text.ToLowerInvariant());
                        }
                    }
            }
            catch { }
        }
        private void physicsDictTb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (((TextBox)sender).Modified)
                    if (file.AllArchetypes != null)
                    {
                        if (file.AllArchetypes[archeotypesCb.SelectedIndex] != null)
                        {
                            file.AllArchetypes[archeotypesCb.SelectedIndex]._BaseArchetypeDef.physicsDictionary = JenkHash.GenHash(physicsDictTb.Text.ToLowerInvariant());
                        }
                    }
            }
            catch { }
        }
        private void drawableDictTb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (((TextBox)sender).Modified)
                    if (file.AllArchetypes != null)
                    {
                        if (file.AllArchetypes[archeotypesCb.SelectedIndex] != null)
                        {
                            file.AllArchetypes[archeotypesCb.SelectedIndex]._BaseArchetypeDef.drawableDictionary = JenkHash.GenHash(drawableDictTb.Text.ToLowerInvariant());
                        }
                    }
            }
            catch { }
        }
        private void specialAttributeCb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (file.AllArchetypes != null)
                {
                    if (file.AllArchetypes[archeotypesCb.SelectedIndex] != null)
                    {
                        file.AllArchetypes[archeotypesCb.SelectedIndex]._BaseArchetypeDef.specialAttribute = Convert.ToUInt32(specialAttributeCb.SelectedIndex);
                    }
                }
            }
            catch { }
        }
        private void bbMinTb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (((TextBox)sender).Modified)
                    if (file.AllArchetypes != null)
                    {
                        if (file.AllArchetypes[archeotypesCb.SelectedIndex] != null)
                        {
                            string[] vals = bbMinTb.Text.Split(',');
                            if (vals.Length == 3)
                            {
                                if (!string.IsNullOrEmpty(vals[0]) && !string.IsNullOrEmpty(vals[1]) && !string.IsNullOrEmpty(vals[2]))
                                {
                                    float r1 = 0.0f;
                                    bool t1 = float.TryParse(vals[0], out r1);
                                    float r2 = 0.0f;
                                    bool t2 = float.TryParse(vals[1], out r2);
                                    float r3 = 0.0f;
                                    bool t3 = float.TryParse(vals[2], out r3);

                                    if (t1 && t2 && t3)
                                    {
                                        bbMinTb.BackColor = System.Drawing.Color.White;
                                        file.AllArchetypes[archeotypesCb.SelectedIndex]._BaseArchetypeDef.bbMin = new SharpDX.Vector3(r1, r2, r3);
                                    }
                                    else bbMinTb.BackColor = System.Drawing.Color.IndianRed;
                                }
                                else bbMinTb.BackColor = System.Drawing.Color.IndianRed;
                            }
                            else bbMinTb.BackColor = System.Drawing.Color.IndianRed;
                        }
                    }
            }
            catch
            {
                bbMinTb.BackColor = System.Drawing.Color.IndianRed;
            }
        }
        private void bbMaxTb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (((TextBox)sender).Modified)
                    if (file.AllArchetypes != null)
                    {
                        if (file.AllArchetypes[archeotypesCb.SelectedIndex] != null)
                        {
                            string[] vals = bbMaxTb.Text.Split(',');
                            if (vals.Length == 3)
                            {
                                if (!string.IsNullOrEmpty(vals[0]) && !string.IsNullOrEmpty(vals[1]) && !string.IsNullOrEmpty(vals[2]))
                                {
                                    float r1 = 0.0f;
                                    bool t1 = float.TryParse(vals[0], out r1);
                                    float r2 = 0.0f;
                                    bool t2 = float.TryParse(vals[1], out r2);
                                    float r3 = 0.0f;
                                    bool t3 = float.TryParse(vals[2], out r3);

                                    if (t1 && t2 && t3)
                                    {
                                        bbMaxTb.BackColor = System.Drawing.Color.White;
                                        file.AllArchetypes[archeotypesCb.SelectedIndex]._BaseArchetypeDef.bbMax = new SharpDX.Vector3(r1, r2, r3);
                                    }
                                    else bbMaxTb.BackColor = System.Drawing.Color.IndianRed;
                                }
                                else bbMaxTb.BackColor = System.Drawing.Color.IndianRed;
                            }
                            else bbMaxTb.BackColor = System.Drawing.Color.IndianRed;
                        }
                    }
            }
            catch
            {
                bbMaxTb.BackColor = System.Drawing.Color.IndianRed;
            }
        }
        private void bsCentreTb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (((TextBox)sender).Modified)
                    if (file.AllArchetypes != null)
                    {
                        if (file.AllArchetypes[archeotypesCb.SelectedIndex] != null)
                        {
                            string[] vals = bsCentreTb.Text.Split(',');
                            if (vals.Length == 3)
                            {
                                if (!string.IsNullOrEmpty(vals[0]) && !string.IsNullOrEmpty(vals[1]) && !string.IsNullOrEmpty(vals[2]))
                                {
                                    float r1 = 0.0f;
                                    bool t1 = float.TryParse(vals[0], out r1);
                                    float r2 = 0.0f;
                                    bool t2 = float.TryParse(vals[1], out r2);
                                    float r3 = 0.0f;
                                    bool t3 = float.TryParse(vals[2], out r3);

                                    if (t1 && t2 && t3)
                                    {
                                        bsCentreTb.BackColor = System.Drawing.Color.White;
                                        file.AllArchetypes[archeotypesCb.SelectedIndex]._BaseArchetypeDef.bsCentre = new SharpDX.Vector3(r1, r2, r3);
                                    }
                                    else bsCentreTb.BackColor = System.Drawing.Color.IndianRed;
                                }
                                else bsCentreTb.BackColor = System.Drawing.Color.IndianRed;
                            }
                            else bsCentreTb.BackColor = System.Drawing.Color.IndianRed;
                        }
                    }
            }
            catch
            {
                bbMaxTb.BackColor = System.Drawing.Color.IndianRed;
            }
        }
        private void bsRadiusTb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (((TextBox)sender).Modified)
                    if (file.AllArchetypes != null)
                    {
                        if (file.AllArchetypes[archeotypesCb.SelectedIndex] != null)
                        {
                            file.AllArchetypes[archeotypesCb.SelectedIndex]._BaseArchetypeDef.bsRadius = Convert.ToSingle(bsRadiusTb.Text);
                        }
                    }
            }
            catch { }
        }
        private void hdTextureDistTb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (((TextBox)sender).Modified)
                    if (file.AllArchetypes != null)
                    {
                        if (file.AllArchetypes[archeotypesCb.SelectedIndex] != null)
                        {
                            file.AllArchetypes[archeotypesCb.SelectedIndex]._BaseArchetypeDef.hdTextureDist = Convert.ToSingle(hdTextureDistTb.Text);
                        }
                    }
            }
            catch { }
        }
        private void lodDistTb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (((TextBox)sender).Modified)
                    if (file.AllArchetypes != null)
                    {
                        if (file.AllArchetypes[archeotypesCb.SelectedIndex] != null)
                        {
                            file.AllArchetypes[archeotypesCb.SelectedIndex]._BaseArchetypeDef.lodDist = Convert.ToSingle(lodDistTb.Text);
                        }
                    }
            }
            catch { }
        }
        #endregion

        private void ClearTextboxes()
        {
            try
            {
                if (archeotypesCb.Items.Count > 0) archeotypesCb.SelectedIndex = 0;
                archeotypesCb.Items.Clear();
                nameTb.Text = "";
                assetNameTb.Text = "";
                if (assetTypeCb.Items.Count > 0) assetTypeCb.SelectedIndex = 0;
                textureDictTb.Text = "";
                physicsDictTb.Text = "";
                drawableDictTb.Text = "";
                if (specialAttributeCb.Items.Count > 0) specialAttributeCb.SelectedIndex = 0;
                for (int i = 0; i < flagsCalcList.Items.Count; i++) flagsCalcList.SetItemChecked(i, false);
                flagsTb.Text = "";
                hdTextureDistTb.Text = "";
                lodDistTb.Text = "";
                bbMinTb.Text = "";
                bbMaxTb.Text = "";
                bsCentreTb.Text = "";
                bsRadiusTb.Text = "";
                loadingLb.Text = "";
                currFileLb.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured while ClearTextboxes. Error message: {ex.Message}");
            }
        }

        private void LoadSettings()
        {
            string settingsFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "mmYtypTool");
            string settingsFilePath = Path.Combine(settingsFolderPath, "settings.txt");
            try
            {
                if(!Directory.Exists(settingsFolderPath))
                {
                    Directory.CreateDirectory(settingsFolderPath);
                }

                if (!File.Exists(settingsFilePath))
                {
                    Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

                    dlg.Title = "Choose your GTA5 exe file";
                    dlg.Multiselect = false;
                    dlg.CheckFileExists = true;
                    dlg.AddExtension = true;
                    dlg.DefaultExt = ".exe";
                    dlg.Filter = "GTA5 exe file|gta5.exe";

                    bool? result = dlg.ShowDialog();
                    if (result == true)
                    {
                        GTAV_exe_path = dlg.FileName;
                        Task.Run(() =>
                        {
                            try
                            {
                                UpdateStatus("Loading keys...");
                                GTA5Keys.LoadFromPath(Path.GetDirectoryName(GTAV_exe_path));
                                GTAV_exe_key = Convert.ToBase64String(GTA5Keys.PC_AES_KEY);
                                string[] to_save_lines = { GTAV_exe_path, GTAV_exe_key };
                                File.WriteAllLines(settingsFilePath, to_save_lines);
                                UpdateStatus("Keys loaded...");
                                LoadSettings();
                            }
                            catch { UpdateStatus("Error occured while loading GTA5 keys"); }
                        });
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    string[] settings_lines = File.ReadAllLines(settingsFilePath);
                    if(settings_lines.Length == 2)
                    {
                        if(!string.IsNullOrEmpty(settings_lines[0]))
                        {
                            GTAV_exe_path = settings_lines[0];
                            GTAV_exe_key = settings_lines[1];
                        }
                        else
                        {
                            File.Delete(settingsFilePath);
                            LoadSettings();
                        }
                    }
                    else
                    {
                        File.Delete(settingsFilePath);
                        LoadSettings();
                    }
                }

                Task.Run(() =>
                {
                    try
                    {
                        string p = Path.GetDirectoryName(GTAV_exe_path);
                        if (Directory.Exists(p))
                        {
                            GTA5Keys.LoadFromPath(p, GTAV_exe_key);
                            RpfMan = new RpfManager();
                            RpfMan.Init(p, UpdateStatus, UpdateStatus, false, true);
                            UpdateStatus("RPFs loaded");
                            Invoke(new Action(() => { fileDropDownBtn.Enabled = true; editModeCb.Enabled = true; toolsBtn.Enabled = true; }));
                        }
                        else
                        {
                            File.Delete(settingsFilePath);
                            LoadSettings();
                        }
                    }
                    catch { UpdateStatus("Error occured while loading RPFs"); }
                });
            }
            catch
            {
                File.Delete(settingsFilePath);
                LoadSettings();
            }
        }

        private void UpdateStatus(string text)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() => { UpdateStatus(text); }));
                }
                else
                {
                    loadingLb.Text = text;
                }
            }
            catch { }
        }

        private MetaHash GetProperHash(string e)
        {
            uint hash = 0;
            bool can = uint.TryParse(e.ToLowerInvariant(), out hash);

            if (can)
            {
                return new MetaHash() { Hash = hash };
            }
            else
            {
                MetaHash metaHash = JenkHash.GenHash(e.ToLowerInvariant());
                JenkIndex.Ensure(e.ToLowerInvariant());
                return metaHash;
            }
        }
    }
}
