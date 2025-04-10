namespace AppTitlesAnime
{
    partial class FormListTypes
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
            flowLayoutPanelTop = new FlowLayoutPanel();
            btnAddType = new Button();
            btnUpdateType = new Button();
            btnDeleteType = new Button();
            dataGridViewTypes = new DataGridView();
            panelFill = new Panel();
            flowLayoutPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).BeginInit();
            panelFill.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.AutoSize = true;
            flowLayoutPanelTop.BackColor = Color.White;
            flowLayoutPanelTop.Controls.Add(btnAddType);
            flowLayoutPanelTop.Controls.Add(btnUpdateType);
            flowLayoutPanelTop.Controls.Add(btnDeleteType);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(10);
            flowLayoutPanelTop.Size = new Size(1002, 61);
            flowLayoutPanelTop.TabIndex = 0;
            // 
            // btnAddType
            // 
            btnAddType.AutoSize = true;
            btnAddType.Location = new Point(13, 13);
            btnAddType.Name = "btnAddType";
            btnAddType.Size = new Size(106, 35);
            btnAddType.TabIndex = 0;
            btnAddType.Text = "Добавить";
            btnAddType.UseVisualStyleBackColor = true;
            btnAddType.Click += btnAddType_Click;
            // 
            // btnUpdateType
            // 
            btnUpdateType.AutoSize = true;
            btnUpdateType.Location = new Point(125, 13);
            btnUpdateType.Name = "btnUpdateType";
            btnUpdateType.Size = new Size(151, 35);
            btnUpdateType.TabIndex = 1;
            btnUpdateType.Text = "Редактировать";
            btnUpdateType.UseVisualStyleBackColor = true;
            // 
            // btnDeleteType
            // 
            btnDeleteType.AutoSize = true;
            btnDeleteType.Location = new Point(282, 13);
            btnDeleteType.Name = "btnDeleteType";
            btnDeleteType.Size = new Size(92, 35);
            btnDeleteType.TabIndex = 2;
            btnDeleteType.Text = "Удалить";
            btnDeleteType.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTypes
            // 
            dataGridViewTypes.BackgroundColor = Color.White;
            dataGridViewTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTypes.Dock = DockStyle.Fill;
            dataGridViewTypes.Location = new Point(10, 10);
            dataGridViewTypes.Name = "dataGridViewTypes";
            dataGridViewTypes.Size = new Size(982, 416);
            dataGridViewTypes.TabIndex = 1;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewTypes);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 61);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(1002, 436);
            panelFill.TabIndex = 2;
            // 
            // FormListTypes
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 497);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormListTypes";
            Text = "Список типов аниме";
            flowLayoutPanelTop.ResumeLayout(false);
            flowLayoutPanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).EndInit();
            panelFill.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTop;
        private Button btnAddType;
        private Button btnUpdateType;
        private Button btnDeleteType;
        private DataGridView dataGridViewTypes;
        private Panel panelFill;
    }
}