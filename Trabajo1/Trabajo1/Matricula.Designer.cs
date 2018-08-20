namespace Trabajo1
{
    partial class Matricula
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.escuelaMatriculaDataSet2 = new Trabajo1.EscuelaMatriculaDataSet2();
            this.cursoTableAdapter = new Trabajo1.EscuelaMatriculaDataSet2TableAdapters.CursoTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.datosPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.escuelaMatriculaDataSet3 = new Trabajo1.EscuelaMatriculaDataSet3();
            this.label2 = new System.Windows.Forms.Label();
            this.datosPTableAdapter = new Trabajo1.EscuelaMatriculaDataSet3TableAdapters.DatosPTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechamatriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.añoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionMatriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.escuelaMatriculaDataSet4 = new Trabajo1.EscuelaMatriculaDataSet4();
            this.button1 = new System.Windows.Forms.Button();
            this.matriculaTableAdapter = new Trabajo1.EscuelaMatriculaDataSet4TableAdapters.MatriculaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuelaMatriculaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuelaMatriculaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matriculaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuelaMatriculaDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curso";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.cursoBindingSource;
            this.comboBox1.DisplayMember = "id_curso";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(74, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "id_curso";
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataMember = "Curso";
            this.cursoBindingSource.DataSource = this.escuelaMatriculaDataSet2;
            // 
            // escuelaMatriculaDataSet2
            // 
            this.escuelaMatriculaDataSet2.DataSetName = "EscuelaMatriculaDataSet2";
            this.escuelaMatriculaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cursoTableAdapter
            // 
            this.cursoTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.datosPBindingSource;
            this.comboBox2.DisplayMember = "id_datosP";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(305, 6);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 27);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "id_datosP";
            // 
            // datosPBindingSource
            // 
            this.datosPBindingSource.DataMember = "DatosP";
            this.datosPBindingSource.DataSource = this.escuelaMatriculaDataSet3;
            // 
            // escuelaMatriculaDataSet3
            // 
            this.escuelaMatriculaDataSet3.DataSetName = "EscuelaMatriculaDataSet3";
            this.escuelaMatriculaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alumno";
            // 
            // datosPTableAdapter
            // 
            this.datosPTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Año";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 26);
            this.textBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Observacion";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 129);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(560, 72);
            this.textBox2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cursoDataGridViewTextBoxColumn,
            this.alumnoDataGridViewTextBoxColumn,
            this.fechamatriculaDataGridViewTextBoxColumn,
            this.añoDataGridViewTextBoxColumn,
            this.observacionMatriculaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.matriculaBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(796, 381);
            this.dataGridView1.TabIndex = 8;
            // 
            // cursoDataGridViewTextBoxColumn
            // 
            this.cursoDataGridViewTextBoxColumn.DataPropertyName = "curso";
            this.cursoDataGridViewTextBoxColumn.HeaderText = "CURSO";
            this.cursoDataGridViewTextBoxColumn.Name = "cursoDataGridViewTextBoxColumn";
            // 
            // alumnoDataGridViewTextBoxColumn
            // 
            this.alumnoDataGridViewTextBoxColumn.DataPropertyName = "alumno";
            this.alumnoDataGridViewTextBoxColumn.HeaderText = "CODIGO ALUMNO";
            this.alumnoDataGridViewTextBoxColumn.Name = "alumnoDataGridViewTextBoxColumn";
            this.alumnoDataGridViewTextBoxColumn.Width = 180;
            // 
            // fechamatriculaDataGridViewTextBoxColumn
            // 
            this.fechamatriculaDataGridViewTextBoxColumn.DataPropertyName = "fecha_matricula";
            this.fechamatriculaDataGridViewTextBoxColumn.HeaderText = "FECHA MATRICULA";
            this.fechamatriculaDataGridViewTextBoxColumn.Name = "fechamatriculaDataGridViewTextBoxColumn";
            this.fechamatriculaDataGridViewTextBoxColumn.Width = 220;
            // 
            // añoDataGridViewTextBoxColumn
            // 
            this.añoDataGridViewTextBoxColumn.DataPropertyName = "año";
            this.añoDataGridViewTextBoxColumn.HeaderText = "AÑO";
            this.añoDataGridViewTextBoxColumn.Name = "añoDataGridViewTextBoxColumn";
            // 
            // observacionMatriculaDataGridViewTextBoxColumn
            // 
            this.observacionMatriculaDataGridViewTextBoxColumn.DataPropertyName = "ObservacionMatricula";
            this.observacionMatriculaDataGridViewTextBoxColumn.HeaderText = "OBSERVACION";
            this.observacionMatriculaDataGridViewTextBoxColumn.Name = "observacionMatriculaDataGridViewTextBoxColumn";
            this.observacionMatriculaDataGridViewTextBoxColumn.Width = 150;
            // 
            // matriculaBindingSource
            // 
            this.matriculaBindingSource.DataMember = "Matricula";
            this.matriculaBindingSource.DataSource = this.escuelaMatriculaDataSet4;
            // 
            // escuelaMatriculaDataSet4
            // 
            this.escuelaMatriculaDataSet4.DataSetName = "EscuelaMatriculaDataSet4";
            this.escuelaMatriculaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(233, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Matricular xdxd";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // matriculaTableAdapter
            // 
            this.matriculaTableAdapter.ClearBeforeFill = true;
            // 
            // Matricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Matricula";
            this.Text = "Matricula";
            this.Load += new System.EventHandler(this.Matricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuelaMatriculaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuelaMatriculaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matriculaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuelaMatriculaDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private EscuelaMatriculaDataSet2 escuelaMatriculaDataSet2;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private EscuelaMatriculaDataSet2TableAdapters.CursoTableAdapter cursoTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private EscuelaMatriculaDataSet3 escuelaMatriculaDataSet3;
        private System.Windows.Forms.BindingSource datosPBindingSource;
        private EscuelaMatriculaDataSet3TableAdapters.DatosPTableAdapter datosPTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private EscuelaMatriculaDataSet4 escuelaMatriculaDataSet4;
        private System.Windows.Forms.BindingSource matriculaBindingSource;
        private EscuelaMatriculaDataSet4TableAdapters.MatriculaTableAdapter matriculaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechamatriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn añoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionMatriculaDataGridViewTextBoxColumn;
    }
}