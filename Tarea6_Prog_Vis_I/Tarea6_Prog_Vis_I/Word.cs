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
        private static readonly object bloqueo = new object();
        public static void EscribirEnWord(string nombreArch, List<int> numeros, string Progreso)
        {
            lock (bloqueo)
            {
                Action worker = () =>
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

                        string contenido = Environment.NewLine + "---Progreso: " + Progreso + " ---" + Environment.NewLine;
                        for (int i = 0; i < numeros.Count; i++)
                        {
                            contenido += numeros[i].ToString();
                            if (i < numeros.Count - 1) contenido += ", ";
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
                        throw;
                    }
                    finally
                    {
                        try
                        {
                            if (doc != null)
                            {
                                try
                                {
                                    object guardarCambios = WdSaveOptions.wdDoNotSaveChanges;
                                    ((_Document)doc).Close(ref guardarCambios, ref faltante, ref faltante);
                                }
                                catch
                                {

                                }

                                try
                                {
                                    Marshal.ReleaseComObject(doc);
                                }
                                catch { }
                                doc = null;
                            }
                        }
                        catch { }

                        try
                        {
                            if (aplWord != null)
                            {
                                try
                                {
                                    aplWord.Quit();
                                }
                                catch
                                {
                                }

                                try
                                {
                                    Marshal.ReleaseComObject(aplWord);
                                }
                                catch { }

                                aplWord = null;
                            }
                        }
                        catch { }

                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    }
                };
                if (System.Threading.Thread.CurrentThread.GetApartmentState() == System.Threading.ApartmentState.STA)
                {
                    try
                    {
                        worker();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error al manipular el archivo Word: " + ex.Message);
                    }
                }
                else
                {
                    Exception threadException = null;
                    using (var doneEvent = new System.Threading.ManualResetEvent(false))
                    {
                        System.Threading.Thread staThread = new System.Threading.Thread(() =>
                        {
                            try
                            {
                                worker();
                            }
                            catch (Exception ex)
                            {
                                threadException = ex;
                            }
                            finally
                            {
                                doneEvent.Set();
                            }
                        });

                        staThread.SetApartmentState(System.Threading.ApartmentState.STA);
                        staThread.IsBackground = true;
                        staThread.Start();
                        doneEvent.WaitOne();

                        if (threadException != null)
                        {
                            MessageBox.Show("Ocurrió un error al manipular el archivo Word: " + threadException.Message);
                        }
                    }
                }
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