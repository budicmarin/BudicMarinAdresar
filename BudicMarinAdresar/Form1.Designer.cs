namespace BudicMarinAdresar
{
    partial class Form1
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
            this.txSearch = new System.Windows.Forms.TextBox();
            this.dgAdresar = new System.Windows.Forms.DataGridView();
            this.btAdd = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAdresar)).BeginInit();
            this.SuspendLayout();
            // 
            // txSearch
            // 
            this.txSearch.Location = new System.Drawing.Point(13, 13);
            this.txSearch.Name = "txSearch";
            this.txSearch.Size = new System.Drawing.Size(615, 22);
            this.txSearch.TabIndex = 0;
            // 
            // dgAdresar
            // 
            this.dgAdresar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAdresar.Location = new System.Drawing.Point(13, 55);
            this.dgAdresar.Name = "dgAdresar";
            this.dgAdresar.RowHeadersWidth = 51;
            this.dgAdresar.RowTemplate.Height = 24;
            this.dgAdresar.Size = new System.Drawing.Size(615, 255);
            this.dgAdresar.TabIndex = 1;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(652, 55);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Dodaj";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(652, 11);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 3;
            this.btSearch.Text = "Pretrazi";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(652, 93);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "Brisi";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dgAdresar);
            this.Controls.Add(this.txSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAdresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txSearch;
        private System.Windows.Forms.DataGridView dgAdresar;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btDelete;
    }
}

