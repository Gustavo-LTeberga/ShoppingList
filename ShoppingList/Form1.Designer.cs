namespace ShoppingList {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pibIcon = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNameProduct = new System.Windows.Forms.Label();
            this.txbProduct = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.libShopping = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pibIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pibIcon
            // 
            this.pibIcon.Image = global::ShoppingList.Properties.Resources.Logo;
            this.pibIcon.Location = new System.Drawing.Point(12, 14);
            this.pibIcon.Name = "pibIcon";
            this.pibIcon.Size = new System.Drawing.Size(84, 88);
            this.pibIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibIcon.TabIndex = 0;
            this.pibIcon.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(102, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(190, 34);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "ShoppingList";
            // 
            // lblNameProduct
            // 
            this.lblNameProduct.AutoSize = true;
            this.lblNameProduct.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProduct.Location = new System.Drawing.Point(104, 197);
            this.lblNameProduct.Name = "lblNameProduct";
            this.lblNameProduct.Size = new System.Drawing.Size(142, 24);
            this.lblNameProduct.TabIndex = 2;
            this.lblNameProduct.Text = "Name Product:";
            // 
            // txbProduct
            // 
            this.txbProduct.Location = new System.Drawing.Point(84, 224);
            this.txbProduct.Name = "txbProduct";
            this.txbProduct.Size = new System.Drawing.Size(176, 22);
            this.txbProduct.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(84, 255);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(176, 26);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // libShopping
            // 
            this.libShopping.FormattingEnabled = true;
            this.libShopping.ItemHeight = 17;
            this.libShopping.Location = new System.Drawing.Point(330, 154);
            this.libShopping.Name = "libShopping";
            this.libShopping.Size = new System.Drawing.Size(358, 208);
            this.libShopping.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(330, 368);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(176, 26);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(512, 368);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(176, 26);
            this.btnDeleteAll.TabIndex = 7;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(748, 530);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.libShopping);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbProduct);
            this.Controls.Add(this.lblNameProduct);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pibIcon);
            this.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":ShoppingList:";
            ((System.ComponentModel.ISupportInitialize)(this.pibIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNameProduct;
        private System.Windows.Forms.TextBox txbProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox libShopping;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDeleteAll;
    }
}

