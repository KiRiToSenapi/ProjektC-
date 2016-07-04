namespace Project_Blutbank
{
    partial class Form3
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
            this.blutbankDataSet = new Project_Blutbank.BlutbankDataSet();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new Project_Blutbank.BlutbankDataSetTableAdapters.PatientTableAdapter();
            this.patientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientVornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBlutgruppeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientErkrankungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxVerwaltungMitarbeiter = new System.Windows.Forms.GroupBox();
            this.buttonLöschenMitarbeiter = new System.Windows.Forms.Button();
            this.buttonHinzufügenMitarbeiter = new System.Windows.Forms.Button();
            this.buttonSpeichernMitarbeiter = new System.Windows.Forms.Button();
            this.buttonLadenMitarbeiter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.blutbankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource2)).BeginInit();
            this.groupBoxVerwaltungMitarbeiter.SuspendLayout();
            this.SuspendLayout();
            // 
            // blutbankDataSet
            // 
            this.blutbankDataSet.DataSetName = "BlutbankDataSet";
            this.blutbankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.blutbankDataSet;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // patientBindingSource1
            // 
            this.patientBindingSource1.DataMember = "Patient";
            this.patientBindingSource1.DataSource = this.blutbankDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIDDataGridViewTextBoxColumn,
            this.patientNameDataGridViewTextBoxColumn,
            this.patientVornameDataGridViewTextBoxColumn,
            this.patientBlutgruppeDataGridViewTextBoxColumn,
            this.patientErkrankungDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 371);
            this.dataGridView1.TabIndex = 0;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "Patient_ID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            this.patientNameDataGridViewTextBoxColumn.DataPropertyName = "Patient_Name";
            this.patientNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            // 
            // patientVornameDataGridViewTextBoxColumn
            // 
            this.patientVornameDataGridViewTextBoxColumn.DataPropertyName = "Patient_Vorname";
            this.patientVornameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            this.patientVornameDataGridViewTextBoxColumn.Name = "patientVornameDataGridViewTextBoxColumn";
            // 
            // patientBlutgruppeDataGridViewTextBoxColumn
            // 
            this.patientBlutgruppeDataGridViewTextBoxColumn.DataPropertyName = "Patient_Blutgruppe";
            this.patientBlutgruppeDataGridViewTextBoxColumn.HeaderText = "Blutgruppe";
            this.patientBlutgruppeDataGridViewTextBoxColumn.Name = "patientBlutgruppeDataGridViewTextBoxColumn";
            // 
            // patientErkrankungDataGridViewTextBoxColumn
            // 
            this.patientErkrankungDataGridViewTextBoxColumn.DataPropertyName = "Patient_Erkrankung";
            this.patientErkrankungDataGridViewTextBoxColumn.HeaderText = "Erkrankung";
            this.patientErkrankungDataGridViewTextBoxColumn.Name = "patientErkrankungDataGridViewTextBoxColumn";
            // 
            // patientBindingSource2
            // 
            this.patientBindingSource2.DataMember = "Patient";
            this.patientBindingSource2.DataSource = this.blutbankDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patiente";
            // 
            // groupBoxVerwaltungMitarbeiter
            // 
            this.groupBoxVerwaltungMitarbeiter.Controls.Add(this.buttonLöschenMitarbeiter);
            this.groupBoxVerwaltungMitarbeiter.Controls.Add(this.buttonHinzufügenMitarbeiter);
            this.groupBoxVerwaltungMitarbeiter.Controls.Add(this.buttonSpeichernMitarbeiter);
            this.groupBoxVerwaltungMitarbeiter.Controls.Add(this.buttonLadenMitarbeiter);
            this.groupBoxVerwaltungMitarbeiter.Location = new System.Drawing.Point(561, 154);
            this.groupBoxVerwaltungMitarbeiter.Name = "groupBoxVerwaltungMitarbeiter";
            this.groupBoxVerwaltungMitarbeiter.Size = new System.Drawing.Size(302, 192);
            this.groupBoxVerwaltungMitarbeiter.TabIndex = 2;
            this.groupBoxVerwaltungMitarbeiter.TabStop = false;
            this.groupBoxVerwaltungMitarbeiter.Text = "Verwaltung Mitarbeiter";
            // 
            // buttonLöschenMitarbeiter
            // 
            this.buttonLöschenMitarbeiter.Location = new System.Drawing.Point(155, 104);
            this.buttonLöschenMitarbeiter.Name = "buttonLöschenMitarbeiter";
            this.buttonLöschenMitarbeiter.Size = new System.Drawing.Size(143, 67);
            this.buttonLöschenMitarbeiter.TabIndex = 3;
            this.buttonLöschenMitarbeiter.Text = "Löschen";
            this.buttonLöschenMitarbeiter.UseVisualStyleBackColor = true;
            // 
            // buttonHinzufügenMitarbeiter
            // 
            this.buttonHinzufügenMitarbeiter.Location = new System.Drawing.Point(6, 104);
            this.buttonHinzufügenMitarbeiter.Name = "buttonHinzufügenMitarbeiter";
            this.buttonHinzufügenMitarbeiter.Size = new System.Drawing.Size(143, 67);
            this.buttonHinzufügenMitarbeiter.TabIndex = 2;
            this.buttonHinzufügenMitarbeiter.Text = "Hinzufügen";
            this.buttonHinzufügenMitarbeiter.UseVisualStyleBackColor = true;
            // 
            // buttonSpeichernMitarbeiter
            // 
            this.buttonSpeichernMitarbeiter.Location = new System.Drawing.Point(155, 31);
            this.buttonSpeichernMitarbeiter.Name = "buttonSpeichernMitarbeiter";
            this.buttonSpeichernMitarbeiter.Size = new System.Drawing.Size(143, 67);
            this.buttonSpeichernMitarbeiter.TabIndex = 1;
            this.buttonSpeichernMitarbeiter.Text = "Speichern";
            this.buttonSpeichernMitarbeiter.UseVisualStyleBackColor = true;
            // 
            // buttonLadenMitarbeiter
            // 
            this.buttonLadenMitarbeiter.Location = new System.Drawing.Point(6, 31);
            this.buttonLadenMitarbeiter.Name = "buttonLadenMitarbeiter";
            this.buttonLadenMitarbeiter.Size = new System.Drawing.Size(143, 67);
            this.buttonLadenMitarbeiter.TabIndex = 0;
            this.buttonLadenMitarbeiter.Text = "Laden";
            this.buttonLadenMitarbeiter.UseVisualStyleBackColor = true;
            this.buttonLadenMitarbeiter.Click += new System.EventHandler(this.buttonLadenMitarbeiter_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 474);
            this.Controls.Add(this.groupBoxVerwaltungMitarbeiter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Personal";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.blutbankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource2)).EndInit();
            this.groupBoxVerwaltungMitarbeiter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BlutbankDataSet blutbankDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private BlutbankDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.BindingSource patientBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource patientBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientVornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientBlutgruppeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientErkrankungDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxVerwaltungMitarbeiter;
        private System.Windows.Forms.Button buttonLöschenMitarbeiter;
        private System.Windows.Forms.Button buttonHinzufügenMitarbeiter;
        private System.Windows.Forms.Button buttonSpeichernMitarbeiter;
        private System.Windows.Forms.Button buttonLadenMitarbeiter;
    }
}