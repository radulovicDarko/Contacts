namespace Contacts.Forms
{
    partial class AddEditPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditPerson));
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(29, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(74, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "{title}";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(169)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 72);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxPhone);
            this.panel2.Controls.Add(this.buttonNew);
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Controls.Add(this.textBoxEmail);
            this.panel2.Controls.Add(this.labelEmail);
            this.panel2.Controls.Add(this.textBoxAddress);
            this.panel2.Controls.Add(this.labelAddress);
            this.panel2.Controls.Add(this.labelPhone);
            this.panel2.Controls.Add(this.textBoxLastName);
            this.panel2.Controls.Add(this.labelLastName);
            this.panel2.Controls.Add(this.textBoxFirstName);
            this.panel2.Controls.Add(this.labelFirstName);
            this.panel2.Location = new System.Drawing.Point(34, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 405);
            this.panel2.TabIndex = 2;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(48, 191);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(372, 20);
            this.textBoxPhone.TabIndex = 3;
            this.textBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPhone_Validating);
            // 
            // buttonNew
            // 
            this.buttonNew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(169)))), ((int)(((byte)(79)))));
            this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew.ForeColor = System.Drawing.Color.White;
            this.buttonNew.Location = new System.Drawing.Point(160, 355);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(153, 28);
            this.buttonNew.TabIndex = 6;
            this.buttonNew.Text = "Add Contact";
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Visible = false;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(169)))), ((int)(((byte)(79)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(160, 355);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(153, 28);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Update Contact";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(49, 311);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(372, 20);
            this.textBoxEmail.TabIndex = 5;
            this.textBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmail_Validating);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(50, 278);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 20);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(49, 247);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(372, 20);
            this.textBoxAddress.TabIndex = 4;
            this.textBoxAddress.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAddress_Validating);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(50, 214);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(62, 20);
            this.labelAddress.TabIndex = 6;
            this.labelAddress.Text = "Address";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(50, 152);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(50, 20);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Phone";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(49, 123);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(372, 20);
            this.textBoxLastName.TabIndex = 2;
            this.textBoxLastName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLastName_Validating);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(50, 90);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(79, 20);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(49, 61);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(372, 20);
            this.textBoxFirstName.TabIndex = 1;
            this.textBoxFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxFirstName_Validating);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(50, 28);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(80, 20);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(541, 575);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEditPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact";
            this.Load += new System.EventHandler(this.AddEditPerson_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox textBoxPhone;
    }
}