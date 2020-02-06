﻿using System;
using System.IO;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace PDFtoZPL.PdfiumViewer
{
    internal partial class NativeMethods
    {
        // Interned strings are cached over AppDomains. This means that when we
        // lock on this string, we actually lock over AppDomain's. The Pdfium
        // library is not thread safe, and this way of locking
        // guarantees that we don't access the Pdfium library from different
        // threads, even when there are multiple AppDomain's in play.
        private static readonly string LockString = String.Intern("e362349b-001d-4cb2-bf55-a71606a3e36f");

        public static void FPDF_AddRef()
        {
            lock (LockString)
            {
                Imports.FPDF_AddRef();
            }
        }

        public static void FPDF_Release()
        {
            lock (LockString)
            {
                Imports.FPDF_Release();
            }
        }

        public static void FPDF_CloseDocument(IntPtr document)
        {
            lock (LockString)
            {
                Imports.FPDF_CloseDocument(document);
            }
        }

        public static int FPDF_GetPageCount(IntPtr document)
        {
            lock (LockString)
            {
                return Imports.FPDF_GetPageCount(document);
            }
        }

        public static uint FPDF_GetDocPermissions(IntPtr document)
        {
            lock (LockString)
            {
                return Imports.FPDF_GetDocPermissions(document);
            }
        }

        public static IntPtr FPDFDOC_InitFormFillEnvironment(IntPtr document, FPDF_FORMFILLINFO formInfo)
        {
            lock (LockString)
            {
                return Imports.FPDFDOC_InitFormFillEnvironment(document, formInfo);
            }
        }

        public static void FPDF_SetFormFieldHighlightColor(IntPtr hHandle, int fieldType, uint color)
        {
            lock (LockString)
            {
                Imports.FPDF_SetFormFieldHighlightColor(hHandle, fieldType, color);
            }
        }

        public static void FPDF_SetFormFieldHighlightAlpha(IntPtr hHandle, byte alpha)
        {
            lock (LockString)
            {
                Imports.FPDF_SetFormFieldHighlightAlpha(hHandle, alpha);
            }
        }

        public static void FORM_DoDocumentJSAction(IntPtr hHandle)
        {
            lock (LockString)
            {
                Imports.FORM_DoDocumentJSAction(hHandle);
            }
        }

        public static void FORM_DoDocumentOpenAction(IntPtr hHandle)
        {
            lock (LockString)
            {
                Imports.FORM_DoDocumentOpenAction(hHandle);
            }
        }

        public static void FPDFDOC_ExitFormFillEnvironment(IntPtr hHandle)
        {
            lock (LockString)
            {
                Imports.FPDFDOC_ExitFormFillEnvironment(hHandle);
            }
        }

        public static void FORM_DoDocumentAAction(IntPtr hHandle, FPDFDOC_AACTION aaType)
        {
            lock (LockString)
            {
                Imports.FORM_DoDocumentAAction(hHandle, aaType);
            }
        }

        public static IntPtr FPDF_LoadPage(IntPtr document, int page_index)
        {
            lock (LockString)
            {
                return Imports.FPDF_LoadPage(document, page_index);
            }
        }

        public static IntPtr FPDFText_LoadPage(IntPtr page)
        {
            lock (LockString)
            {
                return Imports.FPDFText_LoadPage(page);
            }
        }

        public static void FORM_OnAfterLoadPage(IntPtr page, IntPtr _form)
        {
            lock (LockString)
            {
                Imports.FORM_OnAfterLoadPage(page, _form);
            }
        }

        public static void FORM_DoPageAAction(IntPtr page, IntPtr _form, FPDFPAGE_AACTION fPDFPAGE_AACTION)
        {
            lock (LockString)
            {
                Imports.FORM_DoPageAAction(page, _form, fPDFPAGE_AACTION);
            }
        }

        public static double FPDF_GetPageWidth(IntPtr page)
        {
            lock (LockString)
            {
                return Imports.FPDF_GetPageWidth(page);
            }
        }

        public static double FPDF_GetPageHeight(IntPtr page)
        {
            lock (LockString)
            {
                return Imports.FPDF_GetPageHeight(page);
            }
        }

        public static void FORM_OnBeforeClosePage(IntPtr page, IntPtr _form)
        {
            lock (LockString)
            {
                Imports.FORM_OnBeforeClosePage(page, _form);
            }
        }

        public static void FPDFText_ClosePage(IntPtr text_page)
        {
            lock (LockString)
            {
                Imports.FPDFText_ClosePage(text_page);
            }
        }

        public static void FPDF_ClosePage(IntPtr page)
        {
            lock (LockString)
            {
                Imports.FPDF_ClosePage(page);
            }
        }

        public static void FPDF_RenderPage(IntPtr dc, IntPtr page, int start_x, int start_y, int size_x, int size_y, int rotate, FPDF flags)
        {
            lock (LockString)
            {
                Imports.FPDF_RenderPage(dc, page, start_x, start_y, size_x, size_y, rotate, flags);
            }
        }

        public static void FPDF_RenderPageBitmap(IntPtr bitmapHandle, IntPtr page, int start_x, int start_y, int size_x, int size_y, int rotate, FPDF flags)
        {
            lock (LockString)
            {
                Imports.FPDF_RenderPageBitmap(bitmapHandle, page, start_x, start_y, size_x, size_y, rotate, flags);
            }
        }

        public static int FPDF_GetPageSizeByIndex(IntPtr document, int page_index, out double width, out double height)
        {
            lock (LockString)
            {
                return Imports.FPDF_GetPageSizeByIndex(document, page_index, out width, out height);
            }
        }

        public static IntPtr FPDFBitmap_CreateEx(int width, int height, int format, IntPtr first_scan, int stride)
        {
            lock (LockString)
            {
                return Imports.FPDFBitmap_CreateEx(width, height, format, first_scan, stride);
            }
        }

        public static void FPDFBitmap_FillRect(IntPtr bitmapHandle, int left, int top, int width, int height, uint color)
        {
            lock (LockString)
            {
                Imports.FPDFBitmap_FillRect(bitmapHandle, left, top, width, height, color);
            }
        }

        public static IntPtr FPDFBitmap_Destroy(IntPtr bitmapHandle)
        {
            lock (LockString)
            {
                return Imports.FPDFBitmap_Destroy(bitmapHandle);
            }
        }

        public static uint FPDFDest_GetPageIndex(IntPtr document, IntPtr dest)
        {
            lock (LockString)
            {
                return Imports.FPDFDest_GetPageIndex(document, dest);
            }
        }

        public static IntPtr FPDF_BookmarkGetFirstChild(IntPtr document, IntPtr bookmark)
        {
            lock (LockString)
                return Imports.FPDFBookmark_GetFirstChild(document, bookmark);
        }

        public static IntPtr FPDF_BookmarkGetNextSibling(IntPtr document, IntPtr bookmark)
        {
            lock (LockString)
                return Imports.FPDFBookmark_GetNextSibling(document, bookmark);
        }

        public static uint FPDF_BookmarkGetTitle(IntPtr bookmark, byte[]? buffer, uint buflen)
        {
            lock (LockString)
                return Imports.FPDFBookmark_GetTitle(bookmark, buffer, buflen);
        }

        public static IntPtr FPDF_BookmarkGetDest(IntPtr document, IntPtr bookmark)
        {
            lock (LockString)
                return Imports.FPDFBookmark_GetDest(document, bookmark);
        }

        /// <summary>
        /// Opens a document using a .NET Stream. Allows opening huge
        /// PDFs without loading them into memory first.
        /// </summary>
        /// <param name="input">The input Stream. Don't dispose prior to closing the pdf.</param>
        /// <param name="password">Password, if the PDF is protected. Can be null.</param>
        /// <param name="id">Retrieves an IntPtr to the COM object for the Stream. The caller must release this with Marshal.Release prior to Disposing the Stream.</param>
        /// <returns>An IntPtr to the FPDF_DOCUMENT object.</returns>
        public static IntPtr FPDF_LoadCustomDocument(Stream input, string? password, int id)
        {
            var getBlock = Marshal.GetFunctionPointerForDelegate(_getBlockDelegate);

            var access = new FPDF_FILEACCESS
            {
                m_FileLen = (uint)input.Length,
                m_GetBlock = getBlock,
                m_Param = (IntPtr)id
            };

            lock (LockString)
            {
                return Imports.FPDF_LoadCustomDocument(access, password);
            }
        }

        public static FPDF_ERR FPDF_GetLastError()
        {
            lock (LockString)
            {
                return (FPDF_ERR)Imports.FPDF_GetLastError();
            }
        }

        #region Save / Edit Methods
        public static void FPDF_FFLDraw(IntPtr form, IntPtr bitmap, IntPtr page, int start_x, int start_y, int size_x, int size_y, int rotate, FPDF flags)
        {
            lock (LockString)
            {
                Imports.FPDF_FFLDraw(form, bitmap, page, start_x, start_y, size_x, size_y, rotate, flags);
            }
        }
        #endregion

        #region Custom Load/Save Logic
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int FPDF_GetBlockDelegate(IntPtr param, uint position, IntPtr buffer, uint size);

        private static readonly FPDF_GetBlockDelegate _getBlockDelegate = FPDF_GetBlock;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int FPDF_SaveBlockDelegate(IntPtr fileWrite, IntPtr data, uint size);

        private static readonly FPDF_SaveBlockDelegate _saveBlockDelegate = FPDF_SaveBlock;

        private static int FPDF_GetBlock(IntPtr param, uint position, IntPtr buffer, uint size)
        {
            var stream = StreamManager.Get((int)param);
            if (stream == null)
                return 0;
            byte[] managedBuffer = new byte[size];

            stream.Position = position;
            int read = stream.Read(managedBuffer, 0, (int)size);
            if (read != size)
                return 0;

            Marshal.Copy(managedBuffer, 0, buffer, (int)size);
            return 1;
        }

        private static int FPDF_SaveBlock(IntPtr fileWrite, IntPtr data, uint size)
        {
            var write = new FPDF_FILEWRITE();
            Marshal.PtrToStructure(fileWrite, write);

            var stream = StreamManager.Get((int)write.stream);
            if (stream == null)
                return 0;

            byte[] buffer = new byte[size];
            Marshal.Copy(data, buffer, 0, (int)size);

            try
            {
                stream.Write(buffer, 0, (int)size);
                return (int)size;
            }
            catch
            {
                return 0;
            }
        }
        #endregion

        private static class Imports
        {
            [DllImport("pdfium.dll")]
            public static extern void FPDF_AddRef();

            [DllImport("pdfium.dll")]
            public static extern void FPDF_Release();

            [DllImport("pdfium.dll", CharSet = CharSet.Unicode)]
            public static extern IntPtr FPDF_LoadCustomDocument([MarshalAs(UnmanagedType.LPStruct)]FPDF_FILEACCESS access, string? password);

            [DllImport("pdfium.dll")]
            public static extern void FPDF_CloseDocument(IntPtr document);

            [DllImport("pdfium.dll")]
            public static extern int FPDF_GetPageCount(IntPtr document);

            [DllImport("pdfium.dll")]
            public static extern uint FPDF_GetDocPermissions(IntPtr document);

            [DllImport("pdfium.dll")]
            public static extern IntPtr FPDFDOC_InitFormFillEnvironment(IntPtr document, FPDF_FORMFILLINFO formInfo);

            [DllImport("pdfium.dll")]
            public static extern void FPDF_SetFormFieldHighlightColor(IntPtr hHandle, int fieldType, uint color);

            [DllImport("pdfium.dll")]
            public static extern void FPDF_SetFormFieldHighlightAlpha(IntPtr hHandle, byte alpha);

            [DllImport("pdfium.dll")]
            public static extern void FORM_DoDocumentJSAction(IntPtr hHandle);

            [DllImport("pdfium.dll")]
            public static extern void FORM_DoDocumentOpenAction(IntPtr hHandle);

            [DllImport("pdfium.dll")]
            public static extern void FPDFDOC_ExitFormFillEnvironment(IntPtr hHandle);

            [DllImport("pdfium.dll")]
            public static extern void FORM_DoDocumentAAction(IntPtr hHandle, FPDFDOC_AACTION aaType);

            [DllImport("pdfium.dll")]
            public static extern IntPtr FPDF_LoadPage(IntPtr document, int page_index);

            [DllImport("pdfium.dll")]
            public static extern IntPtr FPDFText_LoadPage(IntPtr page);

            [DllImport("pdfium.dll")]
            public static extern void FORM_OnAfterLoadPage(IntPtr page, IntPtr _form);

            [DllImport("pdfium.dll")]
            public static extern void FORM_DoPageAAction(IntPtr page, IntPtr _form, FPDFPAGE_AACTION fPDFPAGE_AACTION);

            [DllImport("pdfium.dll")]
            public static extern double FPDF_GetPageWidth(IntPtr page);

            [DllImport("pdfium.dll")]
            public static extern double FPDF_GetPageHeight(IntPtr page);

            [DllImport("pdfium.dll")]
            public static extern void FORM_OnBeforeClosePage(IntPtr page, IntPtr _form);

            [DllImport("pdfium.dll")]
            public static extern void FPDFText_ClosePage(IntPtr text_page);

            [DllImport("pdfium.dll")]
            public static extern void FPDF_ClosePage(IntPtr page);

            [DllImport("pdfium.dll")]
            public static extern void FPDF_RenderPage(IntPtr dc, IntPtr page, int start_x, int start_y, int size_x, int size_y, int rotate, FPDF flags);

            [DllImport("pdfium.dll")]
            public static extern void FPDF_RenderPageBitmap(IntPtr bitmapHandle, IntPtr page, int start_x, int start_y, int size_x, int size_y, int rotate, FPDF flags);

            [DllImport("pdfium.dll")]
            public static extern int FPDF_GetPageSizeByIndex(IntPtr document, int page_index, out double width, out double height);

            [DllImport("pdfium.dll")]
            public static extern IntPtr FPDFBitmap_CreateEx(int width, int height, int format, IntPtr first_scan, int stride);

            [DllImport("pdfium.dll")]
            public static extern void FPDFBitmap_FillRect(IntPtr bitmapHandle, int left, int top, int width, int height, uint color);

            [DllImport("pdfium.dll")]
            public static extern IntPtr FPDFBitmap_Destroy(IntPtr bitmapHandle);

            [DllImport("pdfium.dll")]
            public static extern uint FPDFDest_GetPageIndex(IntPtr document, IntPtr dest);

            [DllImport("pdfium.dll")]
            public static extern IntPtr FPDFBookmark_GetFirstChild(IntPtr document, IntPtr bookmark);

            [DllImport("pdfium.dll")]
            public static extern IntPtr FPDFBookmark_GetNextSibling(IntPtr document, IntPtr bookmark);

            [DllImport("pdfium.dll")]
            public static extern uint FPDFBookmark_GetTitle(IntPtr bookmark, byte[]? buffer, uint buflen);

            [DllImport("pdfium.dll")]
            public static extern IntPtr FPDFBookmark_GetDest(IntPtr document, IntPtr bookmark);

            [DllImport("pdfium.dll")]
            public static extern uint FPDF_GetLastError();

            #region Save/Edit APIs
            [DllImport("pdfium.dll")]
            public static extern void FPDF_FFLDraw(IntPtr form, IntPtr bitmap, IntPtr page, int start_x, int start_y, int size_x, int size_y, int rotate, FPDF flags);
            #endregion
        }

        [StructLayout(LayoutKind.Sequential)]
        public class FPDF_FORMFILLINFO
        {
            public int version;

            private IntPtr Release;

            private IntPtr FFI_Invalidate;

            private IntPtr FFI_OutputSelectedRect;

            private IntPtr FFI_SetCursor;

            private IntPtr FFI_SetTimer;

            private IntPtr FFI_KillTimer;

            private IntPtr FFI_GetLocalTime;

            private IntPtr FFI_OnChange;

            private IntPtr FFI_GetPage;

            private IntPtr FFI_GetCurrentPage;

            private IntPtr FFI_GetRotation;

            private IntPtr FFI_ExecuteNamedAction;

            private IntPtr FFI_SetTextFieldFocus;

            private IntPtr FFI_DoURIAction;

            private IntPtr FFI_DoGoToAction;

            private IntPtr m_pJsPlatform;

            // XFA support i.e. version 2

            private IntPtr FFI_DisplayCaret;

            private IntPtr FFI_GetCurrentPageIndex;

            private IntPtr FFI_SetCurrentPage;

            private IntPtr FFI_GotoURL;

            private IntPtr FFI_GetPageViewRect;

            private IntPtr FFI_PageEvent;

            private IntPtr FFI_PopupMenu;

            private IntPtr FFI_OpenFile;

            private IntPtr FFI_EmailTo;

            private IntPtr FFI_UploadTo;

            private IntPtr FFI_GetPlatform;

            private IntPtr FFI_GetLanguage;

            private IntPtr FFI_DownloadFromURL;

            private IntPtr FFI_PostRequestURL;

            private IntPtr FFI_PutRequestURL;
        }

        public enum FPDFDOC_AACTION
        {
            WC = 0x10,
            WS = 0x11,
            DS = 0x12,
            WP = 0x13,
            DP = 0x14
        }

        public enum FPDFPAGE_AACTION
        {
            OPEN = 0,
            CLOSE = 1
        }

        [Flags]
        public enum FPDF
        {
            ANNOT = 0x01,
            LCD_TEXT = 0x02,
            NO_NATIVETEXT = 0x04,
            GRAYSCALE = 0x08,
            DEBUG_INFO = 0x80,
            NO_CATCH = 0x100,
            RENDER_LIMITEDIMAGECACHE = 0x200,
            RENDER_FORCEHALFTONE = 0x400,
            PRINTING = 0x800,
            REVERSE_BYTE_ORDER = 0x10
        }

        public enum FPDF_ERR : uint
        {
            SUCCESS = 0,		// No error.
            UNKNOWN = 1,		// Unknown error.
            FILE = 2,		// File not found or could not be opened.
            FORMAT = 3,		// File not in PDF format or corrupted.
            PASSWORD = 4,		// Password required or incorrect password.
            SECURITY = 5,		// Unsupported security scheme.
            PAGE = 6		// Page not found or content error.
        }

        #region Save/Edit Structs and Flags
        [StructLayout(LayoutKind.Sequential)]
        public class FPDF_FILEACCESS
        {
            public uint m_FileLen;
            public IntPtr m_GetBlock;
            public IntPtr m_Param;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class FPDF_FILEWRITE
        {
            public int version;
            public IntPtr WriteBlock;
            public IntPtr stream;
        }
        #endregion
    }
}
