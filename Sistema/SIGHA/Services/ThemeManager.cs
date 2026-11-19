using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIGHA.Services
{
    public static class ThemeManager
    {
        public static void LoadColorFromDatabase()
        {
            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand("SELECT CorTema FROM ConfiguracoesClinica WHERE Id = 1", conn))
                    {
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            string cor = result.ToString();
                            PrimaryColor = cor switch
                            {
                                "Azul"      => Color.FromArgb(25, 118, 210),
                                "Vermelho"  => Color.FromArgb(183, 28, 28),
                                "Verde"     => Color.FromArgb(27, 94, 32),
                                "Roxo"      => Color.FromArgb(106, 27, 154),
                                "Rosa"      => Color.FromArgb(194, 24, 91),
                                "Branco"    => Color.FromArgb(38, 50, 56),
                                _           => Color.FromArgb(0, 131, 143),
                            };
                        }
                    }
                }
            }
            catch { /* Silencioso se banco não existir/acessível ainda */ }
        }

        // Cores padrão (Teal Limpo Metálico / OffWhite)
        public static Color PrimaryColor { get; set; } = Color.FromArgb(0, 150, 136); // Teal 
        public static readonly Color SecondaryColor = Color.FromArgb(236, 240, 241); // Cinza Claro Fundo
        public static readonly Color DarkAccentColor = Color.FromArgb(38, 50, 56); // Cinza Escuro Fontes Principais
        public static readonly Color LightText = Color.White;
        
        public static void ApplyTheme(Control control)
        {
            // Set base form color if it's a form
            if (control is Form form)
            {
                if (form.Name != "Tela_Login") // keep background of login if it's an image
                {
                    if (form.BackgroundImage == null)
                    {
                        form.BackColor = SecondaryColor;
                    }
                }
            }

            foreach (Control c in control.Controls)
            {
                if (c is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = PrimaryColor;
                    btn.ForeColor = LightText;
                    btn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
                    btn.Cursor = Cursors.Hand;
                    
                    // Add Hover effect
                    btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(0, 120, 108); // Darker
                    btn.MouseLeave += (s, e) => btn.BackColor = PrimaryColor;
                }
                else if (c is Panel pnl)
                {
                    // keep sidebar dark gradient possibly, but enforce child controls
                    ApplyTheme(c); 
                }
                else if (c is Label lbl)
                {
                    if (lbl.BackColor == Color.Transparent)
                    {
                        lbl.ForeColor = DarkAccentColor;
                    }
                    lbl.Font = new Font("Segoe UI", lbl.Font.Size, lbl.Font.Style);
                }
                else if (c is TextBox txt)
                {
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                }
                else if (c is ComboBox combo)
                {
                    combo.FlatStyle = FlatStyle.Flat;
                    combo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                }
                else if (c is DataGridView dgv)
                {
                    dgv.BackgroundColor = Color.White;
                    dgv.BorderStyle = BorderStyle.None;
                    dgv.DefaultCellStyle.SelectionBackColor = PrimaryColor;
                    dgv.DefaultCellStyle.SelectionForeColor = Color.White;
                    dgv.EnableHeadersVisualStyles = false;
                    dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = DarkAccentColor;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    // Recurse into container controls
                    if (c.HasChildren)
                    {
                        ApplyTheme(c);
                    }
                }
            }
        }
    }
}
