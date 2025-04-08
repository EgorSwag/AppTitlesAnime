namespace AppTitlesAnime
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnShowTypes = new Button();
            SuspendLayout();
            // 
            // btnShowTypes
            // 
            btnShowTypes.AutoSize = true;
            btnShowTypes.Location = new Point(23, 25);
            btnShowTypes.Name = "btnShowTypes";
            btnShowTypes.Size = new Size(253, 35);
            btnShowTypes.TabIndex = 0;
            btnShowTypes.Text = "Справочник \"Типы аниме\"";
            btnShowTypes.UseVisualStyleBackColor = true;
            btnShowTypes.Click += BtnShowTypes_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1128, 476);
            Controls.Add(btnShowTypes);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormMain";
            Text = "Главная форма";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShowTypes;
    }
}
