namespace DNSChanger
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Server_One = new System.Windows.Forms.Button();
            this.Adapters_ComboBox = new System.Windows.Forms.ComboBox();
            this.Server_Two = new System.Windows.Forms.Button();
            this.Server_Three = new System.Windows.Forms.Button();
            this.Server_Four = new System.Windows.Forms.Button();
            this.Reset_DNS = new System.Windows.Forms.Button();
            this.Apply = new System.Windows.Forms.Button();
            this.Cancel_Selection = new System.Windows.Forms.Button();
            this.Primary_Server_Label_Title = new System.Windows.Forms.Label();
            this.Secondary_Server_Label_Title = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Primary_Server_Label_Name = new System.Windows.Forms.Label();
            this.Secondary_Server_Label_Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DNS_Text_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adapter";
            // 
            // Server_One
            // 
            this.Server_One.Location = new System.Drawing.Point(13, 79);
            this.Server_One.Name = "Server_One";
            this.Server_One.Size = new System.Drawing.Size(75, 23);
            this.Server_One.TabIndex = 1;
            this.Server_One.Text = "Google";
            this.Server_One.UseVisualStyleBackColor = true;
            this.Server_One.Click += new System.EventHandler(this.Server_One_Click);
            // 
            // Adapters_ComboBox
            // 
            this.Adapters_ComboBox.FormattingEnabled = true;
            this.Adapters_ComboBox.Location = new System.Drawing.Point(60, 12);
            this.Adapters_ComboBox.Name = "Adapters_ComboBox";
            this.Adapters_ComboBox.Size = new System.Drawing.Size(180, 21);
            this.Adapters_ComboBox.TabIndex = 2;
            this.Adapters_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Adapters_ComboBox_SelectedIndexChanged);
            // 
            // Server_Two
            // 
            this.Server_Two.Location = new System.Drawing.Point(94, 79);
            this.Server_Two.Name = "Server_Two";
            this.Server_Two.Size = new System.Drawing.Size(75, 23);
            this.Server_Two.TabIndex = 3;
            this.Server_Two.Text = "Google";
            this.Server_Two.UseVisualStyleBackColor = true;
            this.Server_Two.Click += new System.EventHandler(this.Server_Two_Click);
            // 
            // Server_Three
            // 
            this.Server_Three.Location = new System.Drawing.Point(13, 108);
            this.Server_Three.Name = "Server_Three";
            this.Server_Three.Size = new System.Drawing.Size(75, 23);
            this.Server_Three.TabIndex = 4;
            this.Server_Three.Text = "Google";
            this.Server_Three.UseVisualStyleBackColor = true;
            this.Server_Three.Click += new System.EventHandler(this.Server_Three_Click);
            // 
            // Server_Four
            // 
            this.Server_Four.Location = new System.Drawing.Point(94, 108);
            this.Server_Four.Name = "Server_Four";
            this.Server_Four.Size = new System.Drawing.Size(75, 23);
            this.Server_Four.TabIndex = 5;
            this.Server_Four.Text = "Google";
            this.Server_Four.UseVisualStyleBackColor = true;
            this.Server_Four.Click += new System.EventHandler(this.Server_Four_Click);
            // 
            // Reset_DNS
            // 
            this.Reset_DNS.Location = new System.Drawing.Point(13, 137);
            this.Reset_DNS.Name = "Reset_DNS";
            this.Reset_DNS.Size = new System.Drawing.Size(75, 23);
            this.Reset_DNS.TabIndex = 6;
            this.Reset_DNS.Text = "Reset DNS";
            this.Reset_DNS.UseVisualStyleBackColor = true;
            this.Reset_DNS.Click += new System.EventHandler(this.Reset_DNS_Click);
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(13, 226);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 23);
            this.Apply.TabIndex = 7;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // Cancel_Selection
            // 
            this.Cancel_Selection.Location = new System.Drawing.Point(94, 226);
            this.Cancel_Selection.Name = "Cancel_Selection";
            this.Cancel_Selection.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Selection.TabIndex = 8;
            this.Cancel_Selection.Text = "Cancel";
            this.Cancel_Selection.UseVisualStyleBackColor = true;
            this.Cancel_Selection.Click += new System.EventHandler(this.Cancel_Selection_Click);
            // 
            // Primary_Server_Label_Title
            // 
            this.Primary_Server_Label_Title.AutoSize = true;
            this.Primary_Server_Label_Title.Location = new System.Drawing.Point(10, 179);
            this.Primary_Server_Label_Title.Name = "Primary_Server_Label_Title";
            this.Primary_Server_Label_Title.Size = new System.Drawing.Size(75, 13);
            this.Primary_Server_Label_Title.TabIndex = 9;
            this.Primary_Server_Label_Title.Text = "Primary Server";
            // 
            // Secondary_Server_Label_Title
            // 
            this.Secondary_Server_Label_Title.AutoSize = true;
            this.Secondary_Server_Label_Title.Location = new System.Drawing.Point(10, 192);
            this.Secondary_Server_Label_Title.Name = "Secondary_Server_Label_Title";
            this.Secondary_Server_Label_Title.Size = new System.Drawing.Size(92, 13);
            this.Secondary_Server_Label_Title.TabIndex = 10;
            this.Secondary_Server_Label_Title.Text = "Secondary Server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Select two servers";
            // 
            // Primary_Server_Label_Name
            // 
            this.Primary_Server_Label_Name.AutoSize = true;
            this.Primary_Server_Label_Name.Location = new System.Drawing.Point(108, 178);
            this.Primary_Server_Label_Name.Name = "Primary_Server_Label_Name";
            this.Primary_Server_Label_Name.Size = new System.Drawing.Size(0, 13);
            this.Primary_Server_Label_Name.TabIndex = 12;
            // 
            // Secondary_Server_Label_Name
            // 
            this.Secondary_Server_Label_Name.AutoSize = true;
            this.Secondary_Server_Label_Name.Location = new System.Drawing.Point(108, 192);
            this.Secondary_Server_Label_Name.Name = "Secondary_Server_Label_Name";
            this.Secondary_Server_Label_Name.Size = new System.Drawing.Size(0, 13);
            this.Secondary_Server_Label_Name.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Current DNS";
            // 
            // DNS_Text_Box
            // 
            this.DNS_Text_Box.Location = new System.Drawing.Point(241, 79);
            this.DNS_Text_Box.Multiline = true;
            this.DNS_Text_Box.Name = "DNS_Text_Box";
            this.DNS_Text_Box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DNS_Text_Box.Size = new System.Drawing.Size(160, 126);
            this.DNS_Text_Box.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 261);
            this.Controls.Add(this.DNS_Text_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Secondary_Server_Label_Name);
            this.Controls.Add(this.Primary_Server_Label_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Secondary_Server_Label_Title);
            this.Controls.Add(this.Primary_Server_Label_Title);
            this.Controls.Add(this.Cancel_Selection);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.Reset_DNS);
            this.Controls.Add(this.Server_Four);
            this.Controls.Add(this.Server_Three);
            this.Controls.Add(this.Server_Two);
            this.Controls.Add(this.Adapters_ComboBox);
            this.Controls.Add(this.Server_One);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DNSChanger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Server_One;
        private System.Windows.Forms.ComboBox Adapters_ComboBox;
        private System.Windows.Forms.Button Server_Two;
        private System.Windows.Forms.Button Server_Three;
        private System.Windows.Forms.Button Server_Four;
        private System.Windows.Forms.Button Reset_DNS;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Button Cancel_Selection;
        private System.Windows.Forms.Label Primary_Server_Label_Title;
        private System.Windows.Forms.Label Secondary_Server_Label_Title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Primary_Server_Label_Name;
        private System.Windows.Forms.Label Secondary_Server_Label_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DNS_Text_Box;
    }
}

