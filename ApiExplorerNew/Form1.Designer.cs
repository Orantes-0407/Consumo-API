namespace ApiExplorerNew;

partial class Form1
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
        this.tabControl = new System.Windows.Forms.TabControl();
        this.tabPokemon = new System.Windows.Forms.TabPage();
        this.lblStatusPokemon = new System.Windows.Forms.Label();
        this.picPokemon = new System.Windows.Forms.PictureBox();
        this.lblPokemonInfo = new System.Windows.Forms.Label();
        this.btnSearchPokemon = new System.Windows.Forms.Button();
        this.txtPokemonSearch = new System.Windows.Forms.TextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.tabWeather = new System.Windows.Forms.TabPage();
        this.lblStatusWeather = new System.Windows.Forms.Label();
        this.picWeather = new System.Windows.Forms.PictureBox();
        this.lblWeatherInfo = new System.Windows.Forms.Label();
        this.btnSearchWeather = new System.Windows.Forms.Button();
        this.txtWeatherSearch = new System.Windows.Forms.TextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.btnSave = new System.Windows.Forms.Button();
        this.btnClear = new System.Windows.Forms.Button();
        this.tabControl.SuspendLayout();
        this.tabPokemon.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.picPokemon)).BeginInit();
        this.tabWeather.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.picWeather)).BeginInit();
        this.SuspendLayout();
        // 
        // tabControl
        // 
        this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        this.tabControl.Controls.Add(this.tabPokemon);
        this.tabControl.Controls.Add(this.tabWeather);
        this.tabControl.Location = new System.Drawing.Point(12, 12);
        this.tabControl.Name = "tabControl";
        this.tabControl.SelectedIndex = 0;
        this.tabControl.Size = new System.Drawing.Size(776, 385);
        this.tabControl.TabIndex = 0;
        // 
        // tabPokemon
        // 
        this.tabPokemon.Controls.Add(this.lblStatusPokemon);
        this.tabPokemon.Controls.Add(this.picPokemon);
        this.tabPokemon.Controls.Add(this.lblPokemonInfo);
        this.tabPokemon.Controls.Add(this.btnSearchPokemon);
        this.tabPokemon.Controls.Add(this.txtPokemonSearch);
        this.tabPokemon.Controls.Add(this.label1);
        this.tabPokemon.Location = new System.Drawing.Point(4, 29);
        this.tabPokemon.Name = "tabPokemon";
        this.tabPokemon.Padding = new System.Windows.Forms.Padding(3);
        this.tabPokemon.Size = new System.Drawing.Size(768, 352);
        this.tabPokemon.TabIndex = 0;
        this.tabPokemon.Text = "Pokémon";
        this.tabPokemon.UseVisualStyleBackColor = true;
        // 
        // lblStatusPokemon
        // 
        this.lblStatusPokemon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.lblStatusPokemon.AutoSize = true;
        this.lblStatusPokemon.Location = new System.Drawing.Point(6, 326);
        this.lblStatusPokemon.Name = "lblStatusPokemon";
        this.lblStatusPokemon.Size = new System.Drawing.Size(0, 20);
        this.lblStatusPokemon.TabIndex = 5;
        // 
        // picPokemon
        // 
        this.picPokemon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.picPokemon.BackColor = System.Drawing.Color.WhiteSmoke;
        this.picPokemon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.picPokemon.Location = new System.Drawing.Point(590, 50);
        this.picPokemon.Name = "picPokemon";
        this.picPokemon.Size = new System.Drawing.Size(172, 172);
        this.picPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.picPokemon.TabIndex = 4;
        this.picPokemon.TabStop = false;
        // 
        // lblPokemonInfo
        // 
        this.lblPokemonInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        this.lblPokemonInfo.BackColor = System.Drawing.Color.WhiteSmoke;
        this.lblPokemonInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblPokemonInfo.Location = new System.Drawing.Point(6, 50);
        this.lblPokemonInfo.Name = "lblPokemonInfo";
        this.lblPokemonInfo.Size = new System.Drawing.Size(578, 263);
        this.lblPokemonInfo.TabIndex = 3;
        // 
        // btnSearchPokemon
        // 
        this.btnSearchPokemon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnSearchPokemon.Location = new System.Drawing.Point(503, 15);
        this.btnSearchPokemon.Name = "btnSearchPokemon";
        this.btnSearchPokemon.Size = new System.Drawing.Size(94, 29);
        this.btnSearchPokemon.TabIndex = 2;
        this.btnSearchPokemon.Text = "Buscar";
        this.btnSearchPokemon.UseVisualStyleBackColor = true;
        this.btnSearchPokemon.Click += new System.EventHandler(this.btnSearchPokemon_Click);
        // 
        // txtPokemonSearch
        // 
        this.txtPokemonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        this.txtPokemonSearch.Location = new System.Drawing.Point(195, 16);
        this.txtPokemonSearch.Name = "txtPokemonSearch";
        this.txtPokemonSearch.Size = new System.Drawing.Size(302, 27);
        this.txtPokemonSearch.TabIndex = 1;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(6, 19);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(183, 20);
        this.label1.TabIndex = 0;
        this.label1.Text = "Nombre del Pokémon:";
        // 
        // tabWeather
        // 
        this.tabWeather.Controls.Add(this.lblStatusWeather);
        this.tabWeather.Controls.Add(this.picWeather);
        this.tabWeather.Controls.Add(this.lblWeatherInfo);
        this.tabWeather.Controls.Add(this.btnSearchWeather);
        this.tabWeather.Controls.Add(this.txtWeatherSearch);
        this.tabWeather.Controls.Add(this.label2);
        this.tabWeather.Location = new System.Drawing.Point(4, 29);
        this.tabWeather.Name = "tabWeather";
        this.tabWeather.Padding = new System.Windows.Forms.Padding(3);
        this.tabWeather.Size = new System.Drawing.Size(768, 352);
        this.tabWeather.TabIndex = 1;
        this.tabWeather.Text = "Clima";
        this.tabWeather.UseVisualStyleBackColor = true;
        // 
        // lblStatusWeather
        // 
        this.lblStatusWeather.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.lblStatusWeather.AutoSize = true;
        this.lblStatusWeather.Location = new System.Drawing.Point(6, 326);
        this.lblStatusWeather.Name = "lblStatusWeather";
        this.lblStatusWeather.Size = new System.Drawing.Size(0, 20);
        this.lblStatusWeather.TabIndex = 11;
        // 
        // picWeather
        // 
        this.picWeather.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.picWeather.BackColor = System.Drawing.Color.WhiteSmoke;
        this.picWeather.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.picWeather.Location = new System.Drawing.Point(590, 50);
        this.picWeather.Name = "picWeather";
        this.picWeather.Size = new System.Drawing.Size(172, 172);
        this.picWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.picWeather.TabIndex = 10;
        this.picWeather.TabStop = false;
        // 
        // lblWeatherInfo
        // 
        this.lblWeatherInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        this.lblWeatherInfo.BackColor = System.Drawing.Color.WhiteSmoke;
        this.lblWeatherInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblWeatherInfo.Location = new System.Drawing.Point(6, 50);
        this.lblWeatherInfo.Name = "lblWeatherInfo";
        this.lblWeatherInfo.Size = new System.Drawing.Size(578, 263);
        this.lblWeatherInfo.TabIndex = 9;
        // 
        // btnSearchWeather
        // 
        this.btnSearchWeather.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnSearchWeather.Location = new System.Drawing.Point(503, 15);
        this.btnSearchWeather.Name = "btnSearchWeather";
        this.btnSearchWeather.Size = new System.Drawing.Size(94, 29);
        this.btnSearchWeather.TabIndex = 8;
        this.btnSearchWeather.Text = "Buscar";
        this.btnSearchWeather.UseVisualStyleBackColor = true;
        this.btnSearchWeather.Click += new System.EventHandler(this.btnSearchWeather_Click);
        // 
        // txtWeatherSearch
        // 
        this.txtWeatherSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        this.txtWeatherSearch.Location = new System.Drawing.Point(195, 16);
        this.txtWeatherSearch.Name = "txtWeatherSearch";
        this.txtWeatherSearch.Size = new System.Drawing.Size(302, 27);
        this.txtWeatherSearch.TabIndex = 7;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(6, 19);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(163, 20);
        this.label2.TabIndex = 6;
        this.label2.Text = "Nombre de la Ciudad:";
        // 
        // btnSave
        // 
        this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnSave.Location = new System.Drawing.Point(574, 403);
        this.btnSave.Name = "btnSave";
        this.btnSave.Size = new System.Drawing.Size(214, 35);
        this.btnSave.TabIndex = 1;
        this.btnSave.Text = "Guardar Resultados";
        this.btnSave.UseVisualStyleBackColor = true;
        this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
        // 
        // btnClear
        // 
        this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.btnClear.Location = new System.Drawing.Point(12, 403);
        this.btnClear.Name = "btnClear";
        this.btnClear.Size = new System.Drawing.Size(214, 35);
        this.btnClear.TabIndex = 2;
        this.btnClear.Text = "Limpiar Todo";
        this.btnClear.UseVisualStyleBackColor = true;
        this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.btnClear);
        this.Controls.Add(this.btnSave);
        this.Controls.Add(this.tabControl);
        this.Name = "Form1";
        this.Text = "API Explorer";
        this.tabControl.ResumeLayout(false);
        this.tabPokemon.ResumeLayout(false);
        this.tabPokemon.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.picPokemon)).EndInit();
        this.tabWeather.ResumeLayout(false);
        this.tabWeather.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.picWeather)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private TabControl tabControl;
    private TabPage tabPokemon;
    private TabPage tabWeather;
    private Label label1;
    private TextBox txtPokemonSearch;
    private Button btnSearchPokemon;
    private Label lblPokemonInfo;
    private PictureBox picPokemon;
    private Label lblStatusPokemon;
    private Label lblStatusWeather;
    private PictureBox picWeather;
    private Label lblWeatherInfo;
    private Button btnSearchWeather;
    private TextBox txtWeatherSearch;
    private Label label2;
    private Button btnSave;
    private Button btnClear;
}
