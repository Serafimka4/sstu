namespace Lab_5
{
    partial class MessengesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.messengerDBDataSet = new Lab_5.MessengerDBDataSet();
            this.getMessegesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getMessegesTableAdapter = new Lab_5.MessengerDBDataSetTableAdapters.GetMessegesTableAdapter();
            this.tableAdapterManager = new Lab_5.MessengerDBDataSetTableAdapters.TableAdapterManager();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.userToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.userToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.getMessegesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.messengerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMessegesBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getMessegesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // messengerDBDataSet
            // 
            this.messengerDBDataSet.DataSetName = "MessengerDBDataSet";
            this.messengerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getMessegesBindingSource
            // 
            this.getMessegesBindingSource.DataMember = "GetMesseges";
            this.getMessegesBindingSource.DataSource = this.messengerDBDataSet;
            // 
            // getMessegesTableAdapter
            // 
            this.getMessegesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.MsgBoxTableAdapter = null;
            this.tableAdapterManager.MsgUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Lab_5.MessengerDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripLabel,
            this.userToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(667, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            this.fillToolStrip.Visible = false;
            // 
            // userToolStripLabel
            // 
            this.userToolStripLabel.Name = "userToolStripLabel";
            this.userToolStripLabel.Size = new System.Drawing.Size(32, 22);
            this.userToolStripLabel.Text = "user:";
            // 
            // userToolStripTextBox
            // 
            this.userToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userToolStripTextBox.Name = "userToolStripTextBox";
            this.userToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.FillToolStripButton_Click);
            // 
            // getMessegesDataGridView
            // 
            this.getMessegesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getMessegesDataGridView.AutoGenerateColumns = false;
            this.getMessegesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getMessegesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.getMessegesDataGridView.DataSource = this.getMessegesBindingSource;
            this.getMessegesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.getMessegesDataGridView.Name = "getMessegesDataGridView";
            this.getMessegesDataGridView.Size = new System.Drawing.Size(643, 200);
            this.getMessegesDataGridView.TabIndex = 2;
            this.getMessegesDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GetMessegesDataGridView_RowHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MsgFrom";
            this.dataGridViewTextBoxColumn2.HeaderText = "From";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MsgTo";
            this.dataGridViewTextBoxColumn3.HeaderText = "To";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MsgSub";
            this.dataGridViewTextBoxColumn4.HeaderText = "Subject";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MsgBody";
            this.dataGridViewTextBoxColumn5.HeaderText = "Content";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MsgDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "Date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 218);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(642, 167);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // MessengesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 397);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.getMessegesDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Name = "MessengesForm";
            this.Text = "Messages";
            this.Load += new System.EventHandler(this.MessengesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.messengerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMessegesBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getMessegesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MessengerDBDataSet messengerDBDataSet;
        private System.Windows.Forms.BindingSource getMessegesBindingSource;
        private MessengerDBDataSetTableAdapters.GetMessegesTableAdapter getMessegesTableAdapter;
        private MessengerDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel userToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox userToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView getMessegesDataGridView;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}