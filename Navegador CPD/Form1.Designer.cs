namespace Navegador_CPD
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.goButton = new System.Windows.Forms.Button();
            this.addressBar = new System.Windows.Forms.TextBox();
            this.btn_Forward = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_Fav = new System.Windows.Forms.Button();
            this.btn_RemovFav = new System.Windows.Forms.Button();
            this.Dicas = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // webView
            // 
            this.webView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(-1, 33);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(1236, 662);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goButton.FlatAppearance.BorderSize = 0;
            this.goButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goButton.Image = ((System.Drawing.Image)(resources.GetObject("goButton.Image")));
            this.goButton.Location = new System.Drawing.Point(874, 1);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(55, 32);
            this.goButton.TabIndex = 1;
            this.Dicas.SetToolTip(this.goButton, "Clique para pesquisar.");
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // addressBar
            // 
            this.addressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressBar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.addressBar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.addressBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressBar.Location = new System.Drawing.Point(186, 7);
            this.addressBar.Name = "addressBar";
            this.addressBar.Size = new System.Drawing.Size(682, 20);
            this.addressBar.TabIndex = 2;
            this.Dicas.SetToolTip(this.addressBar, "Digite a URL.");
            this.addressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressBar_KeyDown);
            // 
            // btn_Forward
            // 
            this.btn_Forward.FlatAppearance.BorderSize = 0;
            this.btn_Forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Forward.Image = ((System.Drawing.Image)(resources.GetObject("btn_Forward.Image")));
            this.btn_Forward.Location = new System.Drawing.Point(62, 0);
            this.btn_Forward.Name = "btn_Forward";
            this.btn_Forward.Size = new System.Drawing.Size(55, 32);
            this.btn_Forward.TabIndex = 3;
            this.Dicas.SetToolTip(this.btn_Forward, "Clique para avançar.");
            this.btn_Forward.UseVisualStyleBackColor = true;
            this.btn_Forward.Click += new System.EventHandler(this.btn_Forward_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.Location = new System.Drawing.Point(3, 0);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(55, 32);
            this.btn_Back.TabIndex = 4;
            this.btn_Back.Tag = "";
            this.Dicas.SetToolTip(this.btn_Back, "Clique para voltar.");
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("btn_Home.Image")));
            this.btn_Home.Location = new System.Drawing.Point(125, 0);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(55, 32);
            this.btn_Home.TabIndex = 5;
            this.Dicas.SetToolTip(this.btn_Home, "Clique para ir para a página inicial.");
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(935, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 21);
            this.comboBox1.TabIndex = 6;
            this.Dicas.SetToolTip(this.comboBox1, "Selecione seu favorito.");
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_Fav
            // 
            this.btn_Fav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fav.FlatAppearance.BorderSize = 0;
            this.btn_Fav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fav.Image = ((System.Drawing.Image)(resources.GetObject("btn_Fav.Image")));
            this.btn_Fav.Location = new System.Drawing.Point(1119, 1);
            this.btn_Fav.Name = "btn_Fav";
            this.btn_Fav.Size = new System.Drawing.Size(55, 32);
            this.btn_Fav.TabIndex = 7;
            this.Dicas.SetToolTip(this.btn_Fav, "Clique para adicionar aos favoritos.");
            this.btn_Fav.UseVisualStyleBackColor = true;
            this.btn_Fav.Click += new System.EventHandler(this.btn_Fav_Click);
            // 
            // btn_RemovFav
            // 
            this.btn_RemovFav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RemovFav.FlatAppearance.BorderSize = 0;
            this.btn_RemovFav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemovFav.Image = ((System.Drawing.Image)(resources.GetObject("btn_RemovFav.Image")));
            this.btn_RemovFav.Location = new System.Drawing.Point(1175, 1);
            this.btn_RemovFav.Name = "btn_RemovFav";
            this.btn_RemovFav.Size = new System.Drawing.Size(55, 32);
            this.btn_RemovFav.TabIndex = 8;
            this.Dicas.SetToolTip(this.btn_RemovFav, "Clique para remover site dos favoritos.");
            this.btn_RemovFav.UseVisualStyleBackColor = true;
            this.btn_RemovFav.Click += new System.EventHandler(this.btn_RemovFav_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 694);
            this.Controls.Add(this.btn_RemovFav);
            this.Controls.Add(this.btn_Fav);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Forward);
            this.Controls.Add(this.addressBar);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.webView);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Navegador CPD";
            this.Dicas.SetToolTip(this, "Navegador CPD");
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TextBox addressBar;
        private System.Windows.Forms.Button btn_Forward;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_Fav;
        private System.Windows.Forms.Button btn_RemovFav;
        private System.Windows.Forms.ToolTip Dicas;
    }
}

