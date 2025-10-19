using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Tarea6_Prog_Vis_I
{
    public class Word
    {
        private static object faltante = System.Reflection.Missing.Value;

        public static void EscribirEnWord(string nombreArch, List<int> numeros, int Progreso)
        {
            Microsoft.Office.Interop.Word.Application aplWord = null;
            Document doc = null;
            object rutaDoc = null;

            try
            {
                string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string rutaCompleta = Path.Combine(rutaEscritorio, nombreArch + ".doc");
                rutaDoc = rutaCompleta;

                aplWord = new Microsoft.Office.Interop.Word.Application();
                aplWord.Visible = false;
                if (File.Exists(rutaCompleta))
                {
                    doc = aplWord.Documents.Open(ref rutaDoc, ref faltante, ref faltante, ref faltante,
                                                 ref faltante, ref faltante, ref faltante, ref faltante,
                                                 ref faltante, ref faltante, ref faltante, ref faltante,
                                                 ref faltante, ref faltante, ref faltante, ref faltante);
                }
                else
                {
                    doc = aplWord.Documents.Add(ref faltante, ref faltante, ref faltante, ref faltante);
                }

                object finDocItem = WdGoToItem.wdGoToBookmark;
                object finDocNombre = "\\endofdoc";
                aplWord.Selection.GoTo(ref finDocItem, ref faltante, ref faltante, ref finDocNombre);

                string contenido = Environment.NewLine + "---Progreso: " + Progreso.ToString() + " ---" + Environment.NewLine;

                foreach (int num in numeros)
                {
                    contenido += num.ToString() + ", ";
                }
                contenido += Environment.NewLine;

                aplWord.Selection.TypeText(contenido);

                if (File.Exists(rutaCompleta))
                {
                    doc.Save();
                }
                else
                {
                    doc.SaveAs2(ref rutaDoc, ref faltante, ref faltante, ref faltante,
                                ref faltante, ref faltante, ref faltante, ref faltante,
                                ref faltante, ref faltante, ref faltante, ref faltante,
                                ref faltante, ref faltante, ref faltante, ref faltante,
                                ref faltante);
                }

                Console.WriteLine($"El archivo '{rutaCompleta}' ha sido actualizado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al manipular el archivo Word: " + ex.Message);
            }
            finally
            {
                if (doc != null)
                {
                    object guardarCambios = WdSaveOptions.wdDoNotSaveChanges;
                    ((_Document)doc).Close(ref guardarCambios, ref faltante, ref faltante);
                    Marshal.ReleaseComObject(doc);
                    doc = null;
                }

                if (aplWord != null)
                {
                    ((_Application)aplWord).Quit(ref faltante, ref faltante, ref faltante);
                    Marshal.ReleaseComObject(aplWord);
                    aplWord = null;
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
        public static void EliminarDocumentoDeWord(string nombreBase)
        {
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string nombreCompleto = nombreBase + ".doc";
            string rutaCompleta = Path.Combine(rutaEscritorio, nombreCompleto);
            try
            {
                if (File.Exists(rutaCompleta))
                {
                    File.Delete(rutaCompleta);
                    MessageBox.Show($"Archivo '{nombreCompleto}' eliminado correctamente del Escritorio.");
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show($"Error de Acceso: No se pudo eliminar el archivo '{nombreCompleto}'. Asegúrese de que no esté abierto y tenga permisos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al intentar eliminar el archivo: {ex.Message}");
            }
        }
    }
}