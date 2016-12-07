﻿Imports System.Runtime.InteropServices

Class NativeMethods
    Friend Const WM_SETTEXT As Integer = 12
    'NativeMethods.SetWindowTextUnicode(handleYouFound, WM_SETTTEXT, IntPtr.Zero, "shoot")
    <DllImport("user32.dll", EntryPoint:="SendMessageW", CharSet:=CharSet.Unicode)>
    Friend Shared Function SetWindowTextUnicode(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As IntPtr, ByVal lParam As String) As IntPtr
    End Function

    <DllImport("user32.dll", EntryPoint:="SendMessageA", CharSet:=CharSet.Ansi)>
    Friend Shared Function SetWindowTextAnsi(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As IntPtr, ByVal lParam As String) As IntPtr
    End Function

    Public Enum WindowMessages
        WM_ACTIVATE = &H6
        WM_ACTIVATEAPP = &H1C
        WM_ASKCBFORMATNAME = &H30C
        WM_CANCELJOURNAL = &H4B
        WM_CANCELMODE = &H1F
        WM_CAPTURECHANGED = &H1F
        WM_CAPTURECHANGED_R = &H215
        WM_CHANGECBCHAIN = &H30D
        WM_CHAR = &H102
        WM_CHARTOITEM = &H2F
        WM_CHILDACTIVATE = &H22
        WM_CHOOSEFONT_GETLOGFONT = &H401
        WM_CHOOSEFONT_SETFLAGS = (&H400 + 102)
        WM_CHOOSEFONT_SETLOGFONT = (&H400 + 101)
        WM_CLEAR = &H303
        WM_CLOSE = &H10
        WM_COMMAND = &H111
        WM_COMPACTING = &H41
        WM_COMPAREITEM = &H39
        WM_CONTEXTMENU = &H7B
        WM_CONVERTREQUESTEX = &H108
        WM_COPY = &H301
        WM_COPYDATA = &H4A
        WM_CREATE = &H1
        WM_CTLCOLORBTN = &H135
        WM_CTLCOLORDLG = &H136
        WM_CTLCOLOREDIT = &H133
        WM_CTLCOLORLISTBOX = &H134
        WM_CTLCOLORMSGBOX = &H132
        WM_CTLCOLORSCROLLBAR = &H137
        WM_CTLCOLORSTATIC = &H138
        WM_CUT = &H300
        WM_DDE_ACK = (&H3E0 + 4)
        WM_DDE_ADVISE = (&H3E0 + 2)
        WM_DDE_DATA = (&H3E0 + 5)
        WM_DDE_EXECUTE = (&H3E0 + 8)
        WM_DDE_FIRST = &H3E0
        WM_DDE_INITIATE = &H3E0
        WM_DDE_LAST = (&H3E0 + 8)
        WM_DDE_POKE = (&H3E0 + 7)
        WM_DDE_REQUEST = (&H3E0 + 6)
        WM_DDE_TERMINATE = (&H3E0 + 1)
        WM_DDE_UNADVISE = (&H3E0 + 3)
        WM_DEADCHAR = &H103
        WM_DELETEITEM = &H2D
        WM_DESTROY = &H2
        WM_DESTROYCLIPBOARD = &H307
        WM_DEVICECHANGE = &H219
        WM_DEVMODECHANGE = &H1B
        WM_DRAWCLIPBOARD = &H308
        WM_DRAWITEM = &H2B
        WM_DROPFILES = &H233
        WM_ENABLE = &HA
        WM_ENDSESSION = &H16
        WM_ENTERIDLE = &H121
        WM_ENTERSIZEMOVE = &H231
        WM_ENTERMENULOOP = &H211
        WM_ERASEBKGND = &H14
        WM_EXITMENULOOP = &H212
        WM_EXITSIZEMOVE = &H232
        WM_FONTCHANGE = &H1D
        WM_GETDLGCODE = &H87
        WM_GETFONT = &H31
        WM_GETHOTKEY = &H33
        WM_GETMINMAXINFO = &H24
        WM_GETTEXT = &HD
        WM_GETTEXTLENGTH = &HE
        WM_HELP = &H53
        WM_HOTKEY = &H312
        WM_HSCROLL = &H114
        WM_HSCROLLCLIPBOARD = &H30E
        WM_ICONERASEBKGND = &H27
        WM_IME_CHAR = &H286
        WM_IME_COMPOSITION = &H10F
        WM_IME_COMPOSITIONFULL = &H284
        WM_IME_CONTROL = &H283
        WM_IME_ENDCOMPOSITION = &H10E
        WM_IME_KEYDOWN = &H290
        WM_IME_KEYLAST = &H10F
        WM_IME_KEYUP = &H291
        WM_IME_NOTIFY = &H282
        WM_IME_SELECT = &H285
        WM_IME_SETCONTEXT = &H281
        WM_IME_STARTCOMPOSITION = &H10D
        WM_INITDIALOG = &H110
        WM_INITMENU = &H116
        WM_INITMENUPOPUP = &H117
        WM_INPUTLANGCHANGEREQUEST = &H50
        WM_INPUTLANGCHANGE = &H51
        WM_KEYDOWN = &H100
        WM_KEYUP = &H101
        WM_KILLFOCUS = &H8
        WM_LBUTTONDBLCLK = &H203
        WM_LBUTTONDOWN = &H201
        WM_LBUTTONUP = &H202
        WM_MBUTTONDBLCLK = &H209
        WM_MBUTTONDOWN = &H207
        WM_MBUTTONUP = &H208
        WM_MDIACTIVATE = &H222
        WM_MDICASCADE = &H227
        WM_MDICREATE = &H220
        WM_MDIDESTROY = &H221
        WM_MDIGETACTIVE = &H229
        WM_MDIICONARRANGE = &H228
        WM_MDIMAXIMIZE = &H225
        WM_MDINEXT = &H224
        WM_MDIREFRESHMENU = &H234
        WM_MDIRESTORE = &H223
        WM_MDISETMENU = &H230
        WM_MDITILE = &H226
        WM_MEASUREITEM = &H2C
        WM_MENUCHAR = &H120
        WM_MENUSELECT = &H11F
        WM_MENURBUTTONUP = &H122
        WM_MENUDRAG = &H123
        WM_MENUGETOBJECT = &H124
        WM_MENUCOMMAND = &H126
        WM_MOUSEACTIVATE = &H21
        WM_MOUSEHOVER = &H2A1
        WM_MOUSELEAVE = &H2A3
        WM_MOUSEMOVE = &H200
        WM_MOUSEWHEEL = &H20A
        WM_MOVE = &H3
        WM_MOVING = &H216
        WM_NCACTIVATE = &H86
        WM_NCCALCSIZE = &H83
        WM_NCCREATE = &H81
        WM_NCDESTROY = &H82
        WM_NCHITTEST = &H84
        WM_NCLBUTTONDBLCLK = &HA3
        WM_NCLBUTTONDOWN = &HA1
        WM_NCLBUTTONUP = &HA2
        WM_NCMBUTTONDBLCLK = &HA9
        WM_NCMBUTTONDOWN = &HA7
        WM_NCMBUTTONUP = &HA8
        WM_NCMOUSEMOVE = &HA0
        WM_NCPAINT = &H85
        WM_NCRBUTTONDBLCLK = &HA6
        WM_NCRBUTTONDOWN = &HA4
        WM_NCRBUTTONUP = &HA5
        WM_NEXTDLGCTL = &H28
        WM_NEXTMENU = &H213
        WM_NULL = &H0
        WM_PAINT = &HF
        WM_PAINTCLIPBOARD = &H309
        WM_PAINTICON = &H26
        WM_PALETTECHANGED = &H311
        WM_PALETTEISCHANGING = &H310
        WM_PARENTNOTIFY = &H210
        WM_PASTE = &H302
        WM_PENWINFIRST = &H380
        WM_PENWINLAST = &H38F
        WM_POWER = &H48
        WM_POWERBROADCAST = &H218
        WM_PRINT = &H317
        WM_PRINTCLIENT = &H318
        WM_PSD_ENVSTAMPRECT = (&H400 + 5)
        WM_PSD_FULLPAGERECT = (&H400 + 1)
        WM_PSD_GREEKTEXTRECT = (&H400 + 4)
        WM_PSD_MARGINRECT = (&H400 + 3)
        WM_PSD_MINMARGINRECT = (&H400 + 2)
        WM_PSD_PAGESETUPDLG = (&H400)
        WM_PSD_YAFULLPAGERECT = (&H400 + 6)
        WM_QUERYDRAGICON = &H37
        WM_QUERYENDSESSION = &H11
        WM_QUERYNEWPALETTE = &H30F
        WM_QUERYOPEN = &H13
        WM_QUEUESYNC = &H23
        WM_QUIT = &H12
        WM_RBUTTONDBLCLK = &H206
        WM_RBUTTONDOWN = &H204
        WM_RBUTTONUP = &H205
        WM_RENDERALLFORMATS = &H306
        WM_RENDERFORMAT = &H305
        WM_SETCURSOR = &H20
        WM_SETFOCUS = &H7
        WM_SETFONT = &H30
        WM_SETHOTKEY = &H32
        WM_SETREDRAW = &HB
        WM_SETTEXT = &HC
        WM_SETTINGCHANGE = &H1A
        WM_SHOWWINDOW = &H18
        WM_SIZE = &H5
        WM_SIZING = &H214
        WM_SIZECLIPBOARD = &H30B
        WM_SPOOLERSTATUS = &H2A
        WM_SYSCHAR = &H106
        WM_SYSCOLORCHANGE = &H15
        WM_SYSCOMMAND = &H112
        WM_SYSDEADCHAR = &H107
        WM_SYSKEYDOWN = &H104
        WM_SYSKEYUP = &H105
        WM_TIMECHANGE = &H1E
        WM_TIMER = &H113
        WM_UNDO = &H304
        WM_USER = &H400
        WM_VKEYTOITEM = &H2E
        WM_VSCROLL = &H115
        WM_VSCROLLCLIPBOARD = &H30A
        WM_WINDOWPOSCHANGED = &H47
        WM_WINDOWPOSCHANGING = &H46
        WM_WININICHANGE = &H1A
        WM_APPCOMMAND = &H319




        'WM_NULL = 0x00
        'WM_CREATE = 0x01
        'WM_DESTROY = 0x02
        'WM_MOVE = 0x03
        'WM_SIZE = 0x05
        'WM_ACTIVATE = 0x06
        'WM_SETFOCUS = 0x07
        'WM_KILLFOCUS = 0x08
        'WM_ENABLE = 0x0A
        'WM_SETREDRAW = 0x0B
        'WM_SETTEXT = 0x0C
        'WM_GETTEXT = 0x0D
        'WM_GETTEXTLENGTH = 0x0E
        'WM_PAINT = 0x0F
        'WM_CLOSE = 0x10
        'WM_QUERYENDSESSION = 0x11
        'WM_QUIT = 0x12
        'WM_QUERYOPEN = 0x13
        'WM_ERASEBKGND = 0x14
        'WM_SYSCOLORCHANGE = 0x15
        'WM_ENDSESSION = 0x16
        'WM_SYSTEMERROR = 0x17
        'WM_SHOWWINDOW = 0x18
        'WM_CTLCOLOR = 0x19
        'WM_WININICHANGE = 0x1A
        'WM_SETTINGCHANGE = 0x1A
        'WM_DEVMODECHANGE = 0x1B
        'WM_ACTIVATEAPP = 0x1C
        'WM_FONTCHANGE = 0x1D
        'WM_TIMECHANGE = 0x1E
        'WM_CANCELMODE = 0x1F
        'WM_SETCURSOR = 0x20
        'WM_MOUSEACTIVATE = 0x21
        'WM_CHILDACTIVATE = 0x22
        'WM_QUEUESYNC = 0x23
        'WM_GETMINMAXINFO = 0x24
        'WM_PAINTICON = 0x26
        'WM_ICONERASEBKGND = 0x27
        'WM_NEXTDLGCTL = 0x28
        'WM_SPOOLERSTATUS = 0x2A
        'WM_DRAWITEM = 0x2B
        'WM_MEASUREITEM = 0x2C
        'WM_DELETEITEM = 0x2D
        'WM_VKEYTOITEM = 0x2E
        'WM_CHARTOITEM = 0x2F

        'WM_SETFONT = 0x30
        'WM_GETFONT = 0x31
        'WM_SETHOTKEY = 0x32
        'WM_GETHOTKEY = 0x33
        'WM_QUERYDRAGICON = 0x37
        'WM_COMPAREITEM = 0x39
        'WM_COMPACTING = 0x41
        'WM_WINDOWPOSCHANGING = 0x46
        'WM_WINDOWPOSCHANGED = 0x47
        'WM_POWER = 0x48
        'WM_COPYDATA = 0x4A
        'WM_CANCELJOURNAL = 0x4B
        'WM_NOTIFY = 0x4E
        'WM_INPUTLANGCHANGEREQUEST = 0x50
        'WM_INPUTLANGCHANGE = 0x51
        'WM_TCARD = 0x52
        'WM_HELP = 0x53
        'WM_USERCHANGED = 0x54
        'WM_NOTIFYFORMAT = 0x55
        'WM_CONTEXTMENU = 0x7B
        'WM_STYLECHANGING = 0x7C
        'WM_STYLECHANGED = 0x7D
        'WM_DISPLAYCHANGE = 0x7E
        'WM_GETICON = 0x7F
        'WM_SETICON = 0x80

        'WM_NCCREATE = 0x81
        'WM_NCDESTROY = 0x82
        'WM_NCCALCSIZE = 0x83
        'WM_NCHITTEST = 0x84
        'WM_NCPAINT = 0x85
        'WM_NCACTIVATE = 0x86
        'WM_GETDLGCODE = 0x87
        'WM_NCMOUSEMOVE = 0xA0
        'WM_NCLBUTTONDOWN = 0xA1
        'WM_NCLBUTTONUP = 0xA2
        'WM_NCLBUTTONDBLCLK = 0xA3
        'WM_NCRBUTTONDOWN = 0xA4
        'WM_NCRBUTTONUP = 0xA5
        'WM_NCRBUTTONDBLCLK = 0xA6
        'WM_NCMBUTTONDOWN = 0xA7
        'WM_NCMBUTTONUP = 0xA8
        'WM_NCMBUTTONDBLCLK = 0xA9

        'WM_KEYFIRST = 0x100
        'WM_KEYDOWN = 0x100
        'WM_KEYUP = 0x101
        'WM_CHAR = 0x102
        'WM_DEADCHAR = 0x103
        'WM_SYSKEYDOWN = 0x104
        'WM_SYSKEYUP = 0x105
        'WM_SYSCHAR = 0x106
        'WM_SYSDEADCHAR = 0x107
        'WM_KEYLAST = 0x108

        'WM_IME_STARTCOMPOSITION = 0x10D
        'WM_IME_ENDCOMPOSITION = 0x10E
        'WM_IME_COMPOSITION = 0x10F
        'WM_IME_KEYLAST = 0x10F

        'WM_INITDIALOG = 0x110
        'WM_COMMAND = 0x111
        'WM_SYSCOMMAND = 0x112
        'WM_TIMER = 0x113
        'WM_HSCROLL = 0x114
        'WM_VSCROLL = 0x115
        'WM_INITMENU = 0x116
        'WM_INITMENUPOPUP = 0x117
        'WM_MENUSELECT = 0x11F
        'WM_MENUCHAR = 0x120
        'WM_ENTERIDLE = 0x121

        'WM_CTLCOLORMSGBOX = 0x132
        'WM_CTLCOLOREDIT = 0x133
        'WM_CTLCOLORLISTBOX = 0x134
        'WM_CTLCOLORBTN = 0x135
        'WM_CTLCOLORDLG = 0x136
        'WM_CTLCOLORSCROLLBAR = 0x137
        'WM_CTLCOLORSTATIC = 0x138

        'WM_MOUSEFIRST = 0x200
        'WM_MOUSEMOVE = 0x200
        'WM_LBUTTONDOWN = 0x201
        'WM_LBUTTONUP = 0x202
        'WM_LBUTTONDBLCLK = 0x203
        'WM_RBUTTONDOWN = 0x204
        'WM_RBUTTONUP = 0x205
        'WM_RBUTTONDBLCLK = 0x206
        'WM_MBUTTONDOWN = 0x207
        'WM_MBUTTONUP = 0x208
        'WM_MBUTTONDBLCLK = 0x209
        'WM_MOUSEWHEEL = 0x20A
        'WM_MOUSEHWHEEL = 0x20E

        'WM_PARENTNOTIFY = 0x210
        'WM_ENTERMENULOOP = 0x211
        'WM_EXITMENULOOP = 0x212
        'WM_NEXTMENU = 0x213
        'WM_SIZING = 0x214
        'WM_CAPTURECHANGED = 0x215
        'WM_MOVING = 0x216
        'WM_POWERBROADCAST = 0x218
        'WM_DEVICECHANGE = 0x219

        'WM_MDICREATE = 0x220
        'WM_MDIDESTROY = 0x221
        'WM_MDIACTIVATE = 0x222
        'WM_MDIRESTORE = 0x223
        'WM_MDINEXT = 0x224
        'WM_MDIMAXIMIZE = 0x225
        'WM_MDITILE = 0x226
        'WM_MDICASCADE = 0x227
        'WM_MDIICONARRANGE = 0x228
        'WM_MDIGETACTIVE = 0x229
        'WM_MDISETMENU = 0x230
        'WM_ENTERSIZEMOVE = 0x231
        'WM_EXITSIZEMOVE = 0x232
        'WM_DROPFILES = 0x233
        'WM_MDIREFRESHMENU = 0x234

        'WM_IME_SETCONTEXT = 0x281
        'WM_IME_NOTIFY = 0x282
        'WM_IME_CONTROL = 0x283
        'WM_IME_COMPOSITIONFULL = 0x284
        'WM_IME_SELECT = 0x285
        'WM_IME_CHAR = 0x286
        'WM_IME_KEYDOWN = 0x290
        'WM_IME_KEYUP = 0x291

        'WM_MOUSEHOVER = 0x2A1
        'WM_NCMOUSELEAVE = 0x2A2
        'WM_MOUSELEAVE = 0x2A3

        'WM_CUT = 0x300
        'WM_COPY = 0x301
        'WM_PASTE = 0x302
        'WM_CLEAR = 0x303
        'WM_UNDO = 0x304

        'WM_RENDERFORMAT = 0x305
        'WM_RENDERALLFORMATS = 0x306
        'WM_DESTROYCLIPBOARD = 0x307
        'WM_DRAWCLIPBOARD = 0x308
        'WM_PAINTCLIPBOARD = 0x309
        'WM_VSCROLLCLIPBOARD = 0x30A
        'WM_SIZECLIPBOARD = 0x30B
        'WM_ASKCBFORMATNAME = 0x30C
        'WM_CHANGECBCHAIN = 0x30D
        'WM_HSCROLLCLIPBOARD = 0x30E
        'WM_QUERYNEWPALETTE = 0x30F
        'WM_PALETTEISCHANGING = 0x310
        'WM_PALETTECHANGED = 0x311

        'WM_HOTKEY = 0x312
        'WM_PRINT = 0x317
        'WM_PRINTCLIENT = 0x318

        'WM_HANDHELDFIRST = 0x358
        'WM_HANDHELDLAST = 0x35F
        'WM_PENWINFIRST = 0x380
        'WM_PENWINLAST = 0x38F
        'WM_COALESCE_FIRST = 0x390
        'WM_COALESCE_LAST = 0x39F
        'WM_DDE_FIRST = 0x3E0
        'WM_DDE_INITIATE = 0x3E0
        'WM_DDE_TERMINATE = 0x3E1
        'WM_DDE_ADVISE = 0x3E2
        'WM_DDE_UNADVISE = 0x3E3
        'WM_DDE_ACK = 0x3E4
        'WM_DDE_DATA = 0x3E5
        'WM_DDE_REQUEST = 0x3E6
        'WM_DDE_POKE = 0x3E7
        'WM_DDE_EXECUTE = 0x3E8
        'WM_DDE_LAST = 0x3E8

        'WM_USER = 0x400
        'WM_APP = 0x8000
    End Enum
End Class
