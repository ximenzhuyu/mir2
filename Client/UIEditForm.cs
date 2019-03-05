using Client.MirControls;
using Client.MirGraphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class UIEditForm : Form
    {
        private TreeNode _selectedNode;

        public UIEditForm()
        {
            InitializeComponent();

            var libs = typeof(Libraries).GetFields(BindingFlags.Public | BindingFlags.Static)
                .Where(f => f.FieldType == typeof(MLibrary)).Select(f => new LibSelectItem() { Name = f.Name, Lib = (MLibrary)f.GetValue(null)}).ToList();
            foreach (var lib in libs)
            {
                LibFilesSelect.Items.Add(lib);
            }
        }

        private void ReloadBtn_Click(object sender, EventArgs e)
        {
            if(MirScene.ActiveScene != null)
            {
                ControlsTree.Nodes.Add(AddNode(MirScene.ActiveScene));
            }
        }

        private TreeNode AddNode( MirControl control)
        {
            var newNode = new TreeNode();
            newNode.Text = control.UniqueName;
            newNode.Tag = control;
            if(control.Controls.Count > 0)
            {
                foreach (var _control in control.Controls)
                {
                    newNode.Nodes.Add(AddNode(_control));
                }
            }
            return newNode;
        }

        private void ControlsTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var node = ControlsTree.SelectedNode;
            if(_selectedNode != null && _selectedNode.Tag is MirControl prevControl)
            {
                prevControl.Border = false;
            }
            if(node != null && node.Tag is MirControl control)
            {
                control.BorderColour = Color.Red;
                control.Border = true;
                UIConfigKeyTextBox.Text = control.UIConfigOverrideKey;
                UniqueNameTextBox.Text = control.UniqueName;
                PositionXTextBox.Text = control.Location.X.ToString();
                PositionYTextBox.Text = control.Location.Y.ToString();
                if(control is MirImageControl imageControl)
                {
                    IndexTextBox.Text = imageControl.Index.ToString();
                    if (imageControl.Library != null)
                    {
                        foreach (LibSelectItem item in LibFilesSelect.Items)
                        {
                            if(item.Lib == imageControl.Library)
                            {
                                LibFilesSelect.SelectedItem = item;
                                break;
                            }
                        }
                    }
                }
                
            }
            _selectedNode = node;
        }

        private class LibSelectItem
        {
            public string Name;
            public MLibrary Lib;

            public override string ToString()
            {
                return Name;
            }
        }

        private void PositionXTextbox_TextChanged(object sender, EventArgs e)
        {
            if (sender != ActiveControl) return;
            if(_selectedNode != null && _selectedNode.Tag is MirControl control && int.TryParse(PositionXTextBox.Text, out var x))
            {
                control.Location = new Point(x, control.Location.Y);
            }
        }

        private void PositionYTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender != ActiveControl) return;
            if (_selectedNode != null && _selectedNode.Tag is MirControl control && int.TryParse(PositionYTextBox.Text, out var y))
            {
                control.Location = new Point(control.Location.X, y);
            }
        }

        private void LibFilesSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender != ActiveControl) return;
            if (_selectedNode != null && _selectedNode.Tag is MirImageControl control)
            {
                var lib = typeof(Libraries).GetFields(BindingFlags.Public | BindingFlags.Static)
                    .Where(f => f.FieldType == typeof(MLibrary) &&
                                f.Name == ((LibSelectItem) LibFilesSelect.SelectedItem).Name)
                    .Select(f => (MLibrary) f.GetValue(null)).FirstOrDefault();
                if (lib != null)
                {
                    control.Library = lib;
                }
            }
        }

        private void IndexTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender != ActiveControl) return;
            if (_selectedNode != null && _selectedNode.Tag is MirImageControl control && int.TryParse(IndexTextBox.Text, out var index))
            {
                control.Index = index;
            }
        }

        private void AddAndSave_Click(object sender, EventArgs e)
        {
            if (_selectedNode.Tag is MirImageControl control)
            {
                var _override = new ControlConfigOverride();
                if (int.TryParse(PositionXTextBox.Text, out var x)) _override.PositionX = x;
                if (int.TryParse(PositionYTextBox.Text, out var y)) _override.PositionY = y;
                var lib = typeof(Libraries).GetFields(BindingFlags.Public | BindingFlags.Static)
                    .Where(f => f.FieldType == typeof(MLibrary) &&
                                f.Name == ((LibSelectItem)LibFilesSelect.SelectedItem).Name)
                    .Select(f => (MLibrary)f.GetValue(null)).FirstOrDefault();
                if (lib != null)
                {
                    _override.LibFile = ((LibSelectItem)LibFilesSelect.SelectedItem).Name;
                }
                if (int.TryParse(IndexTextBox.Text, out var index)) _override.Index = index;

                ControlConfigOverride.AddOverride(control.UIConfigOverrideKey, _override);
                ControlConfigOverride.SaveConfig();
            }
        }
    }

}
