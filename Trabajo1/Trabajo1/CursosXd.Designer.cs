namespace Trabajo1
{
    partial class Curso
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idcursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionMesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursos = new Trabajo1.Cursos();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cursoTableAdapter = new Trabajo1.CursosTableAdapters.CursoTableAdapter();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cURSOID = new Trabajo1.CURSOID();
            this.cursoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cursoTableAdapter1 = new Trabajo1.CURSOIDTableAdapters.CursoTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURSOID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre ";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(126, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 26);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(126, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(331, 26);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Duracion";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(126, 157);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(331, 26);
            this.textBox3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Observacion";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
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
            this.idcursoDataGridViewTextBoxColumn,
            this.nomCursoDataGridViewTextBoxColumn,
            this.duracionMesDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cursoBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(876, 316);
            this.dataGridView1.TabIndex = 7;
            // 
            // idcursoDataGridViewTextBoxColumn
            // 
            this.idcursoDataGridViewTextBoxColumn.DataPropertyName = "id_curso";
            this.idcursoDataGridViewTextBoxColumn.HeaderText = "CODIGO";
            this.idcursoDataGridViewTextBoxColumn.Name = "idcursoDataGridViewTextBoxColumn";
            this.idcursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcursoDataGridViewTextBoxColumn.Width = 150;
            // 
            // nomCursoDataGridViewTextBoxColumn
            // 
            this.nomCursoDataGridViewTextBoxColumn.DataPropertyName = "NomCurso";
            this.nomCursoDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nomCursoDataGridViewTextBoxColumn.Name = "nomCursoDataGridViewTextBoxColumn";
            this.nomCursoDataGridViewTextBoxColumn.Width = 200;
            // 
            // duracionMesDataGridViewTextBoxColumn
            // 
            this.duracionMesDataGridViewTextBoxColumn.DataPropertyName = "DuracionMes";
            this.duracionMesDataGridViewTextBoxColumn.HeaderText = "MESES DE DURACION";
            this.duracionMesDataGridViewTextBoxColumn.Name = "duracionMesDataGridViewTextBoxColumn";
            this.duracionMesDataGridViewTextBoxColumn.Width = 200;
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "OBSERVACIONES";
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            this.observacionesDataGridViewTextBoxColumn.Width = 250;
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataMember = "Curso";
            this.cursoBindingSource.DataSource = this.cursos;
            // 
            // cursos
            // 
            this.cursos.DataSetName = "Cursos";
            this.cursos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(13, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(166, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cursoTableAdapter
            // 
            this.cursoTableAdapter.ClearBeforeFill = true;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(12, 240);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(318, 26);
            this.textBox4.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "NomCurso",
            "DuracionMes",
            "observaciones"});
            this.comboBox1.Location = new System.Drawing.Point(336, 239);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "NomCurso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Codigo";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.cursoBindingSource1;
            this.comboBox2.DisplayMember = "id_curso";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(126, 25);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(333, 27);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.ValueMember = "id_curso";
            // 
            // cURSOID
            // 
            this.cURSOID.DataSetName = "CURSOID";
            this.cURSOID.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cursoBindingSource1
            // 
            this.cursoBindingSource1.DataMember = "Curso";
            this.cursoBindingSource1.DataSource = this.cURSOID;
            // 
            // cursoTableAdapter1
            // 
            this.cursoTableAdapter1.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(319, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 36);
            this.button3.TabIndex = 10;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Curso";
            this.Text = "Curso";
            this.Load += new System.EventHandler(this.CursosXd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURSOID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Cursos cursos;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private CursosTableAdapters.CursoTableAdapter cursoTableAdapter;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionMesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private CURSOID cURSOID;
        private System.Windows.Forms.BindingSource cursoBindingSource1;
        private CURSOIDTableAdapters.CursoTableAdapter cursoTableAdapter1;
        private System.Windows.Forms.Button button3;
    }
}