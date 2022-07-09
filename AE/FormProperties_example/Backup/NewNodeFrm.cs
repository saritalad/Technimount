using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormProperties_example
{
    public partial class NewNodeFrm : Form
    {



        #region Local Variables

        private string mNewNodeName;
        private string mNewNodeText;
        private string mNewNodeTag;


        #endregion

        #region Class Properties

        public string NewNodeName
        {
            get
            {
                return mNewNodeName;
            }
            set
            {
                mNewNodeName = value;
            }
        }

        public string NewNodeText
        {
            get
            {
                return mNewNodeText;
            }
            set
            {
                mNewNodeText = value;
            }
        }


        public string NewNodeTag
        {
            get
            {
                return mNewNodeTag;
            }
            set
            {
                mNewNodeTag = value;
            }
        }


        #endregion

        public NewNodeFrm()
        {
            InitializeComponent();
        }

        private void NewNodeFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtNewNodeName.Text != string.Empty)
            {
                NewNodeName = txtNewNodeName.Text;
            }
            else
            {
                MessageBox.Show("enter Name of node.");
                return;
            }

            if (txtNewNodeText.Text != string.Empty)
            {
                NewNodeText = txtNewNodeText.Text;
            }
            else
            {
                MessageBox.Show("Provide the new node's text");
                return;
            }

            if (txtTag.Text != string.Empty)
            {
                NewNodeTag = txtTag.Text;
            }
            else
            {
                MessageBox.Show("Provide the new node's text");
                return;
            }

            this.Close();

        }
    }
}
