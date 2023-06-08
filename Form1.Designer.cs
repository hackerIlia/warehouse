namespace abracadabra
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelPostavshik = new System.Windows.Forms.Label();
            this.labelChek = new System.Windows.Forms.Label();
            this.labelChekZakazchik = new System.Windows.Forms.Label();
            this.labelJurnal = new System.Windows.Forms.Label();
            this.labelNakladnaia = new System.Windows.Forms.Label();
            this.labelNaklPostavshik = new System.Windows.Forms.Label();
            this.labelTipTovara = new System.Windows.Forms.Label();
            this.labelTovar = new System.Windows.Forms.Label();
            this.labelZakazchik = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelChangeUser = new System.Windows.Forms.Label();
            this.labelAdministration = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAdministration = new System.Windows.Forms.Button();
            this.buttonChangeUser = new System.Windows.Forms.Button();
            this.buttonZakazchik = new System.Windows.Forms.Button();
            this.buttonTovar = new System.Windows.Forms.Button();
            this.buttonTipTovara = new System.Windows.Forms.Button();
            this.buttonNaklPostavshik = new System.Windows.Forms.Button();
            this.buttonNakladnaia = new System.Windows.Forms.Button();
            this.buttonJurnal = new System.Windows.Forms.Button();
            this.buttonChekZakazchik = new System.Windows.Forms.Button();
            this.buttonChek = new System.Windows.Forms.Button();
            this.buttonPostavshik = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPostavshik
            // 
            this.labelPostavshik.AutoSize = true;
            this.labelPostavshik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPostavshik.Location = new System.Drawing.Point(35, 234);
            this.labelPostavshik.Name = "labelPostavshik";
            this.labelPostavshik.Size = new System.Drawing.Size(213, 42);
            this.labelPostavshik.TabIndex = 11;
            this.labelPostavshik.Text = "Поставщик";
            // 
            // labelChek
            // 
            this.labelChek.AutoSize = true;
            this.labelChek.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChek.Location = new System.Drawing.Point(101, 737);
            this.labelChek.Name = "labelChek";
            this.labelChek.Size = new System.Drawing.Size(83, 42);
            this.labelChek.TabIndex = 12;
            this.labelChek.Text = "Чек";
            // 
            // labelChekZakazchik
            // 
            this.labelChekZakazchik.AutoSize = true;
            this.labelChekZakazchik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChekZakazchik.Location = new System.Drawing.Point(564, 481);
            this.labelChekZakazchik.Name = "labelChekZakazchik";
            this.labelChekZakazchik.Size = new System.Drawing.Size(199, 33);
            this.labelChekZakazchik.TabIndex = 13;
            this.labelChekZakazchik.Text = "Чек-заказчик";
            // 
            // labelJurnal
            // 
            this.labelJurnal.AutoSize = true;
            this.labelJurnal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelJurnal.Location = new System.Drawing.Point(859, 481);
            this.labelJurnal.Name = "labelJurnal";
            this.labelJurnal.Size = new System.Drawing.Size(121, 33);
            this.labelJurnal.TabIndex = 14;
            this.labelJurnal.Text = "Журнал";
            // 
            // labelNakladnaia
            // 
            this.labelNakladnaia.AutoSize = true;
            this.labelNakladnaia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNakladnaia.Location = new System.Drawing.Point(37, 481);
            this.labelNakladnaia.Name = "labelNakladnaia";
            this.labelNakladnaia.Size = new System.Drawing.Size(211, 42);
            this.labelNakladnaia.TabIndex = 15;
            this.labelNakladnaia.Text = "Накладная";
            // 
            // labelNaklPostavshik
            // 
            this.labelNaklPostavshik.AutoSize = true;
            this.labelNaklPostavshik.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNaklPostavshik.Location = new System.Drawing.Point(281, 496);
            this.labelNaklPostavshik.Name = "labelNaklPostavshik";
            this.labelNaklPostavshik.Size = new System.Drawing.Size(236, 25);
            this.labelNaklPostavshik.TabIndex = 16;
            this.labelNaklPostavshik.Text = "Накладная-поставщик";
            // 
            // labelTipTovara
            // 
            this.labelTipTovara.AutoSize = true;
            this.labelTipTovara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTipTovara.Location = new System.Drawing.Point(583, 245);
            this.labelTipTovara.Name = "labelTipTovara";
            this.labelTipTovara.Size = new System.Drawing.Size(165, 33);
            this.labelTipTovara.TabIndex = 17;
            this.labelTipTovara.Text = "Тип товара";
            // 
            // labelTovar
            // 
            this.labelTovar.AutoSize = true;
            this.labelTovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTovar.Location = new System.Drawing.Point(884, 243);
            this.labelTovar.Name = "labelTovar";
            this.labelTovar.Size = new System.Drawing.Size(96, 33);
            this.labelTovar.TabIndex = 18;
            this.labelTovar.Text = "Товар";
            // 
            // labelZakazchik
            // 
            this.labelZakazchik.AutoSize = true;
            this.labelZakazchik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelZakazchik.Location = new System.Drawing.Point(313, 234);
            this.labelZakazchik.Name = "labelZakazchik";
            this.labelZakazchik.Size = new System.Drawing.Size(181, 42);
            this.labelZakazchik.TabIndex = 19;
            this.labelZakazchik.Text = "Заказчик";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelChangeUser
            // 
            this.labelChangeUser.AutoSize = true;
            this.labelChangeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChangeUser.Location = new System.Drawing.Point(811, 753);
            this.labelChangeUser.Name = "labelChangeUser";
            this.labelChangeUser.Size = new System.Drawing.Size(222, 25);
            this.labelChangeUser.TabIndex = 22;
            this.labelChangeUser.Text = "Смена пользователя";
            // 
            // labelAdministration
            // 
            this.labelAdministration.AutoSize = true;
            this.labelAdministration.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdministration.Location = new System.Drawing.Point(289, 752);
            this.labelAdministration.Name = "labelAdministration";
            this.labelAdministration.Size = new System.Drawing.Size(217, 25);
            this.labelAdministration.TabIndex = 24;
            this.labelAdministration.Text = "Администрирование";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 40);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Image = global::abracadabra.Properties.Resources.help_question_1566;
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(160, 36);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = global::abracadabra.Properties.Resources.information_info_15651;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(215, 36);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // buttonAdministration
            // 
            this.buttonAdministration.BackgroundImage = global::abracadabra.Properties.Resources.admin_lock_padlock_icon_205893;
            this.buttonAdministration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAdministration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdministration.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonAdministration.Location = new System.Drawing.Point(286, 560);
            this.buttonAdministration.Name = "buttonAdministration";
            this.buttonAdministration.Size = new System.Drawing.Size(233, 174);
            this.buttonAdministration.TabIndex = 23;
            this.buttonAdministration.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdministration.UseVisualStyleBackColor = true;
            this.buttonAdministration.Click += new System.EventHandler(this.buttonAdministration_Click);
            // 
            // buttonChangeUser
            // 
            this.buttonChangeUser.BackgroundImage = global::abracadabra.Properties.Resources._4105943_accounts_group_people_user_user_group_users_113923__1_;
            this.buttonChangeUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonChangeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeUser.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonChangeUser.Location = new System.Drawing.Point(802, 561);
            this.buttonChangeUser.Name = "buttonChangeUser";
            this.buttonChangeUser.Size = new System.Drawing.Size(233, 174);
            this.buttonChangeUser.TabIndex = 21;
            this.buttonChangeUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonChangeUser.UseVisualStyleBackColor = true;
            this.buttonChangeUser.Click += new System.EventHandler(this.buttonChangeUser_Click);
            // 
            // buttonZakazchik
            // 
            this.buttonZakazchik.BackgroundImage = global::abracadabra.Properties.Resources.order_confirmation_icon_181878;
            this.buttonZakazchik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonZakazchik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonZakazchik.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonZakazchik.Location = new System.Drawing.Point(284, 57);
            this.buttonZakazchik.Name = "buttonZakazchik";
            this.buttonZakazchik.Size = new System.Drawing.Size(233, 174);
            this.buttonZakazchik.TabIndex = 10;
            this.buttonZakazchik.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonZakazchik.UseVisualStyleBackColor = true;
            this.buttonZakazchik.Click += new System.EventHandler(this.buttonZakazchik_Click);
            // 
            // buttonTovar
            // 
            this.buttonTovar.BackgroundImage = global::abracadabra.Properties.Resources.product_delivery_icon_152013;
            this.buttonTovar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTovar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonTovar.Location = new System.Drawing.Point(802, 58);
            this.buttonTovar.Name = "buttonTovar";
            this.buttonTovar.Size = new System.Drawing.Size(233, 174);
            this.buttonTovar.TabIndex = 9;
            this.buttonTovar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTovar.UseVisualStyleBackColor = true;
            this.buttonTovar.Click += new System.EventHandler(this.buttonTovar_Click);
            // 
            // buttonTipTovara
            // 
            this.buttonTipTovara.BackgroundImage = global::abracadabra.Properties.Resources.productapplication_producto_3010;
            this.buttonTipTovara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTipTovara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTipTovara.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonTipTovara.Location = new System.Drawing.Point(543, 57);
            this.buttonTipTovara.Name = "buttonTipTovara";
            this.buttonTipTovara.Size = new System.Drawing.Size(233, 174);
            this.buttonTipTovara.TabIndex = 8;
            this.buttonTipTovara.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTipTovara.UseVisualStyleBackColor = true;
            this.buttonTipTovara.Click += new System.EventHandler(this.buttonTipTovara_Click);
            // 
            // buttonNaklPostavshik
            // 
            this.buttonNaklPostavshik.BackgroundImage = global::abracadabra.Properties.Resources.delivery_courier_man_people_avatar_shipping_icon_225134;
            this.buttonNaklPostavshik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNaklPostavshik.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNaklPostavshik.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonNaklPostavshik.Location = new System.Drawing.Point(284, 304);
            this.buttonNaklPostavshik.Name = "buttonNaklPostavshik";
            this.buttonNaklPostavshik.Size = new System.Drawing.Size(233, 174);
            this.buttonNaklPostavshik.TabIndex = 7;
            this.buttonNaklPostavshik.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNaklPostavshik.UseVisualStyleBackColor = true;
            this.buttonNaklPostavshik.Click += new System.EventHandler(this.buttonNaklPostavshik_Click);
            // 
            // buttonNakladnaia
            // 
            this.buttonNakladnaia.BackgroundImage = global::abracadabra.Properties.Resources.invoice_document_bill_delivery_note_icon_225116;
            this.buttonNakladnaia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNakladnaia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNakladnaia.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonNakladnaia.Location = new System.Drawing.Point(26, 304);
            this.buttonNakladnaia.Name = "buttonNakladnaia";
            this.buttonNakladnaia.Size = new System.Drawing.Size(233, 174);
            this.buttonNakladnaia.TabIndex = 6;
            this.buttonNakladnaia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNakladnaia.UseVisualStyleBackColor = true;
            this.buttonNakladnaia.Click += new System.EventHandler(this.buttonNakladnaia_Click);
            // 
            // buttonJurnal
            // 
            this.buttonJurnal.BackgroundImage = global::abracadabra.Properties.Resources.magazine_3724;
            this.buttonJurnal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonJurnal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonJurnal.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonJurnal.Location = new System.Drawing.Point(802, 304);
            this.buttonJurnal.Name = "buttonJurnal";
            this.buttonJurnal.Size = new System.Drawing.Size(233, 174);
            this.buttonJurnal.TabIndex = 5;
            this.buttonJurnal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonJurnal.UseVisualStyleBackColor = true;
            this.buttonJurnal.Click += new System.EventHandler(this.buttonJurnal_Click);
            // 
            // buttonChekZakazchik
            // 
            this.buttonChekZakazchik.BackgroundImage = global::abracadabra.Properties.Resources._3709736_customer_listen_paraphrase_service_understand_108091;
            this.buttonChekZakazchik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonChekZakazchik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChekZakazchik.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonChekZakazchik.Location = new System.Drawing.Point(546, 304);
            this.buttonChekZakazchik.Name = "buttonChekZakazchik";
            this.buttonChekZakazchik.Size = new System.Drawing.Size(233, 174);
            this.buttonChekZakazchik.TabIndex = 4;
            this.buttonChekZakazchik.UseVisualStyleBackColor = true;
            this.buttonChekZakazchik.Click += new System.EventHandler(this.buttonChekZakazchik_Click);
            // 
            // buttonChek
            // 
            this.buttonChek.BackgroundImage = global::abracadabra.Properties.Resources.clipboard_check_black_symbol_icon_icons_com_54571;
            this.buttonChek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonChek.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChek.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonChek.Location = new System.Drawing.Point(26, 560);
            this.buttonChek.Name = "buttonChek";
            this.buttonChek.Size = new System.Drawing.Size(233, 174);
            this.buttonChek.TabIndex = 3;
            this.buttonChek.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonChek.UseVisualStyleBackColor = true;
            this.buttonChek.Click += new System.EventHandler(this.чекToolStripMenuItem_Click);
            // 
            // buttonPostavshik
            // 
            this.buttonPostavshik.BackgroundImage = global::abracadabra.Properties.Resources.truck_side_view_icon_icons_com_70347;
            this.buttonPostavshik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPostavshik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPostavshik.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPostavshik.Location = new System.Drawing.Point(26, 57);
            this.buttonPostavshik.Name = "buttonPostavshik";
            this.buttonPostavshik.Size = new System.Drawing.Size(233, 174);
            this.buttonPostavshik.TabIndex = 2;
            this.buttonPostavshik.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPostavshik.UseVisualStyleBackColor = true;
            this.buttonPostavshik.Click += new System.EventHandler(this.поставщикToolStripMenuItem_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(848, 850);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(340, 33);
            label1.TabIndex = 26;
            label1.Text = "© Маринов Илья, 2023";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 892);
            this.Controls.Add(label1);
            this.Controls.Add(this.labelAdministration);
            this.Controls.Add(this.buttonAdministration);
            this.Controls.Add(this.labelChangeUser);
            this.Controls.Add(this.buttonChangeUser);
            this.Controls.Add(this.labelZakazchik);
            this.Controls.Add(this.labelTovar);
            this.Controls.Add(this.labelTipTovara);
            this.Controls.Add(this.labelNaklPostavshik);
            this.Controls.Add(this.labelNakladnaia);
            this.Controls.Add(this.labelJurnal);
            this.Controls.Add(this.labelChekZakazchik);
            this.Controls.Add(this.labelChek);
            this.Controls.Add(this.labelPostavshik);
            this.Controls.Add(this.buttonZakazchik);
            this.Controls.Add(this.buttonTovar);
            this.Controls.Add(this.buttonTipTovara);
            this.Controls.Add(this.buttonNaklPostavshik);
            this.Controls.Add(this.buttonNakladnaia);
            this.Controls.Add(this.buttonJurnal);
            this.Controls.Add(this.buttonChekZakazchik);
            this.Controls.Add(this.buttonChek);
            this.Controls.Add(this.buttonPostavshik);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оптовый склад";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPostavshik;
        private System.Windows.Forms.Button buttonChek;
        private System.Windows.Forms.Button buttonChekZakazchik;
        private System.Windows.Forms.Button buttonJurnal;
        private System.Windows.Forms.Button buttonNakladnaia;
        private System.Windows.Forms.Button buttonNaklPostavshik;
        private System.Windows.Forms.Button buttonTipTovara;
        private System.Windows.Forms.Button buttonTovar;
        private System.Windows.Forms.Button buttonZakazchik;
        private System.Windows.Forms.Label labelPostavshik;
        private System.Windows.Forms.Label labelChek;
        private System.Windows.Forms.Label labelChekZakazchik;
        private System.Windows.Forms.Label labelJurnal;
        private System.Windows.Forms.Label labelNakladnaia;
        private System.Windows.Forms.Label labelNaklPostavshik;
        private System.Windows.Forms.Label labelTipTovara;
        private System.Windows.Forms.Label labelTovar;
        private System.Windows.Forms.Label labelZakazchik;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonChangeUser;
        private System.Windows.Forms.Label labelChangeUser;
        private System.Windows.Forms.Button buttonAdministration;
        private System.Windows.Forms.Label labelAdministration;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}

