// uAPI_test1Dlg.cpp : implementation file
//

#include "stdafx.h"
#include "uAPI_test1.h"
#include "uAPI_test1Dlg.h"
#include "axufiapi.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

int	DI_Valid=0,DO_Valid=0;
void upadte_DI_Status(void);
void upadte_DO_Status(void);
void show_BIOSID_and_BoardID(void);

typedef int (WINAPI *HWMPROC)(float *);

// CAboutDlg dialog used for App About

class CAboutDlg : public CDialog
{
public:
	CAboutDlg();

// Dialog Data
	enum { IDD = IDD_ABOUTBOX };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

// Implementation
protected:
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialog(CAboutDlg::IDD)
{
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialog)
END_MESSAGE_MAP()


// CuAPI_test1Dlg dialog




CuAPI_test1Dlg::CuAPI_test1Dlg(CWnd* pParent /*=NULL*/)
	: CDialog(CuAPI_test1Dlg::IDD, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CuAPI_test1Dlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CuAPI_test1Dlg, CDialog)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	//}}AFX_MSG_MAP
	ON_BN_CLICKED(IDOK, &CuAPI_test1Dlg::OnBnClickedOk)
	
	ON_BN_CLICKED(IDC_DO_Demo, &CuAPI_test1Dlg::OnBnClickedDoDemo)
	ON_BN_CLICKED(IDC_RADIO33, &CuAPI_test1Dlg::OnBnClickedRadio33)
	ON_BN_CLICKED(IDC_RADIO34, &CuAPI_test1Dlg::OnBnClickedRadio34)
	ON_BN_CLICKED(IDC_RADIO37, &CuAPI_test1Dlg::OnBnClickedRadio37)
	ON_BN_CLICKED(IDC_RADIO38, &CuAPI_test1Dlg::OnBnClickedRadio38)
	ON_BN_CLICKED(IDC_WDT_ENABLE, &CuAPI_test1Dlg::OnBnClickedWdtEnable)
	ON_BN_CLICKED(IDC_WDT_RELOAD, &CuAPI_test1Dlg::OnBnClickedWdtReload)
	ON_BN_CLICKED(IDC_WDT_STATUS, &CuAPI_test1Dlg::OnBnClickedWdtStatus)
	ON_BN_CLICKED(IDC_EVENT_CLR, &CuAPI_test1Dlg::OnBnClickedEventClr)
	ON_BN_CLICKED(IDC_Loading, &CuAPI_test1Dlg::OnBnClickedLoading)
	ON_BN_CLICKED(IDC_CHECK57, &CuAPI_test1Dlg::OnBnClickedCheck57)
	ON_BN_CLICKED(IDC_CHECK56, &CuAPI_test1Dlg::OnBnClickedCheck56)
	ON_BN_CLICKED(IDC_CHECK55, &CuAPI_test1Dlg::OnBnClickedCheck55)
	ON_BN_CLICKED(IDC_CHECK54, &CuAPI_test1Dlg::OnBnClickedCheck54)
	ON_BN_CLICKED(IDC_CHECK53, &CuAPI_test1Dlg::OnBnClickedCheck53)
	ON_BN_CLICKED(IDC_CHECK52, &CuAPI_test1Dlg::OnBnClickedCheck52)
	ON_BN_CLICKED(IDC_CHECK51, &CuAPI_test1Dlg::OnBnClickedCheck51)
	ON_BN_CLICKED(IDC_CHECK50, &CuAPI_test1Dlg::OnBnClickedCheck50)
	ON_EN_CHANGE(IDC_LibraryInput, &CuAPI_test1Dlg::OnEnChangeLibraryinput)
END_MESSAGE_MAP()


// CuAPI_test1Dlg message handlers

BOOL CuAPI_test1Dlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// Add "About..." menu item to system menu.

	// IDM_ABOUTBOX must be in the system command range.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		CString strAboutMenu;
		strAboutMenu.LoadString(IDS_ABOUTBOX);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon

	// TODO: Add extra initialization here
	
	show_BIOSID_and_BoardID();

	return TRUE;  // return TRUE  unless you set the focus to a control
}

void CuAPI_test1Dlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialog::OnSysCommand(nID, lParam);
	}
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CuAPI_test1Dlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialog::OnPaint();
	}
}

// The system calls this function to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CuAPI_test1Dlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}


void CuAPI_test1Dlg::OnBnClickedOk()
{
CWnd* pWnd;
float temp=0;
//char biosid[10];
int OS_VER,iRet, iRet2;

SBC_DS2401	*sbc_bid;
BOOL bootRet;
char xBuff[20];


//HINSTANCE hinstLib;
//MYPROC ProcAdd; 
	// TODO: Add your control notification handler code here
	//get BIOS ID

	sbc_bid=(SBC_DS2401 *)_malloca(sizeof SBC_DS2401);
	OS_VER=AxOS_Version();
	
	//if ( bootRet ) {
		/** CPU Temp  **/
//HINSTANCE hinstLib=NULL;
//HWMPROC ProcAdd;
//BOOL boolRet=false;
//float *fValue;
//	hinstLib = LoadLibrary("dt86831x32.dll"); 

	//hinstLib = LoadLibrary("dll86831.dll"); 

//	if (hinstLib != NULL) 
  //  { 	
	//	ProcAdd = (HWMPROC) GetProcAddress(hinstLib, TEXT("_subAxGetCPUTemp")); 
        // If the function address is valid, call the function.
     //   if (NULL != ProcAdd)  boolRet=(ProcAdd)(fValue);
	//}
//	return ;



		bootRet=AxGetCPUTemp(&temp);
		_gcvt_s(xBuff, 20, temp, 3);
		pWnd = GetDlgItem(IDC_CPUTemp_EDIT);
		if (bootRet) pWnd->SetWindowText((LPCTSTR)xBuff);
		else		 pWnd->SetWindowText("Not Supported");

		/** SYS Temp  **/
		bootRet=AxGetSYSTemp(&temp);
		_gcvt_s(xBuff, 20, temp, 3);
		pWnd = GetDlgItem(IDC_SYSTemp_EDIT);
		if (bootRet) pWnd->SetWindowText((LPCTSTR)xBuff);
		else		 pWnd->SetWindowText("Not Supported");

		/** GMCH Temp  **/
		bootRet=AxGetGMCHTemp(&temp);
		_gcvt_s(xBuff, 20, temp, 3);
		pWnd = GetDlgItem(IDC_GMCHTemp_EDIT);
		if (bootRet) pWnd->SetWindowText((LPCTSTR)xBuff);
		else		 pWnd->SetWindowText("Not Supported");


		/** CPU FAN  **/
		bootRet=AxGetCPUFAN(&temp);
		_gcvt_s(xBuff, 20, temp, 5);
		pWnd = GetDlgItem(IDC_CPUFAN_EDIT);
		if (bootRet) pWnd->SetWindowText((LPCTSTR)xBuff);
		else		 pWnd->SetWindowText("Not Supported");

		/** SYS FAN  **/
		bootRet=AxGetGMCHFAN(&temp);
		_gcvt_s(xBuff, 20, temp, 5);
		pWnd = GetDlgItem(IDC_GMCHFAN_EDIT);
		if (bootRet) pWnd->SetWindowText((LPCTSTR)xBuff);
		else		 pWnd->SetWindowText("Not Supported");

		/** GMCH FAN  **/
		bootRet=AxGetSYSFAN(&temp);
		_gcvt_s(xBuff, 20, temp, 5);
		pWnd = GetDlgItem(IDC_SYSFAN_EDIT);
		if (bootRet) pWnd->SetWindowText((LPCTSTR)xBuff);
		else		 pWnd->SetWindowText("Not Supported");

		/** CPU Vcore  **/
		bootRet=AxGetCPUVcore(&temp);
		_gcvt_s(xBuff, 20, temp, 3);
		pWnd = GetDlgItem(IDC_CPUVcore_EDIT);
		if (bootRet) pWnd->SetWindowText((LPCTSTR)xBuff);
		else		 pWnd->SetWindowText("Not Supported");

		/** 3.3V  **/
		bootRet=AxGet3V(&temp);
		_gcvt_s(xBuff, 20, temp, 3);
		pWnd = GetDlgItem(IDC_3V_EDIT);
		if (bootRet) pWnd->SetWindowText((LPCTSTR)xBuff);
		else		 pWnd->SetWindowText("Not Supported");

		/** 5V  **/
		bootRet=AxGet5V(&temp);
		_gcvt_s(xBuff, 20, temp, 3);
		pWnd = GetDlgItem(IDC_5V_EDIT);
		if (bootRet) pWnd->SetWindowText((LPCTSTR)xBuff);
		else		 pWnd->SetWindowText("Not Supported");

		/** 12V  **/
		bootRet=AxGet12V(&temp);
		_gcvt_s(xBuff, 20, temp, 4);
		pWnd = GetDlgItem(IDC_12V_EDIT);
		if (bootRet) pWnd->SetWindowText((LPCTSTR)xBuff);
		else		 pWnd->SetWindowText("Not Supported");
				
		/** N5V  **/
		bootRet=AxGetNeg5V(&temp);
		_gcvt_s(xBuff, 20, temp, 5);
		pWnd = GetDlgItem(IDC_N5V_EDIT);
		if (bootRet) pWnd->SetWindowText((LPCTSTR)xBuff);
		else		 pWnd->SetWindowText("Not Supported");

		/** N12V  **/
		bootRet=AxGetNeg12V(&temp);
		_gcvt_s(xBuff, 20, temp, 5);
		pWnd = GetDlgItem(IDC_N12V_EDIT);
		if (bootRet) pWnd->SetWindowText((LPCTSTR)xBuff);
		else		 pWnd->SetWindowText("Not Supported");

		/** Vbat  **/
		bootRet=AxGetVbat(&temp);
		_gcvt_s(xBuff, 20, temp, 3);
		pWnd = GetDlgItem(IDC_Vbat_EDIT);
		if (bootRet) pWnd->SetWindowText((LPCTSTR)xBuff);
		else		 pWnd->SetWindowText("Not Supported");
	//}
	
	iRet=AxGetDI(1, &iRet2);
	//OnOK();
}





int DO_out=0x80;

void CuAPI_test1Dlg::OnBnClickedDoDemo()
{
int xi;
	AxGetDIOValidPin(1, &DI_Valid);
	AxGetDIOValidPin(2, &DO_Valid);
	// TODO: Add your control notification handler code here
	if ( DO_Valid != 0 ) {
		for (xi=0 ; xi<8 ; xi++) {
			DO_out = DO_out << 1 ;
			if (DO_out >= 0x100) DO_out=0x01 ;	//back to  bit 0 
			if (DO_out & DO_Valid) xi=8; //match next valid pin 
		}
	}
	AxSetDO(DO_Valid, &DO_out); 
	//get DI Status and upadte GUI
	upadte_DI_Status();
	//get DO Status and upadte GUI
	upadte_DO_Status();

}

void CuAPI_test1Dlg::upadte_DI_Status(void)
{
CWnd* pWnd;
int DI_Status=0;
	//get all DI status
	AxGetDI(DI_Valid, &DI_Status );
	//DI Pin0
	if ( DI_Valid & DIO_PIN0 ) {
		if ( DI_Status & DIO_PIN0 )	CheckRadioButton(IDC_RADIO1, IDC_RADIO2, IDC_RADIO1);   
		else						CheckRadioButton(IDC_RADIO1, IDC_RADIO2, IDC_RADIO2);  
		pWnd = GetDlgItem(IDC_RADIO1);
		pWnd->EnableWindow(1);
		pWnd = GetDlgItem(IDC_RADIO2);
		pWnd->EnableWindow(1);
	}
	else { 
		pWnd = GetDlgItem(IDC_RADIO1);
		pWnd->EnableWindow(0);
		pWnd = GetDlgItem(IDC_RADIO2);
		pWnd->EnableWindow(0);
	} 

	//DI Pin1
	if ( DI_Valid & DIO_PIN1 ) {
		if ( DI_Status & DIO_PIN1 )	CheckRadioButton(IDC_RADIO3, IDC_RADIO4, IDC_RADIO3);   
		else						CheckRadioButton(IDC_RADIO3, IDC_RADIO4, IDC_RADIO4);   
		pWnd = GetDlgItem(IDC_RADIO3);
		pWnd->EnableWindow(1);
		pWnd = GetDlgItem(IDC_RADIO4);
		pWnd->EnableWindow(1);
	}
	else {
		pWnd = GetDlgItem(IDC_RADIO3);
		pWnd->EnableWindow(0);
		pWnd = GetDlgItem(IDC_RADIO4);
		pWnd->EnableWindow(0);
	} 

	//DI Pin2
	if ( DI_Valid & DIO_PIN2 ) {
		if ( DI_Status & DIO_PIN2 )	CheckRadioButton(IDC_RADIO5, IDC_RADIO6, IDC_RADIO5);   
		else						CheckRadioButton(IDC_RADIO5, IDC_RADIO6, IDC_RADIO6); 
		pWnd = GetDlgItem(IDC_RADIO5);
		pWnd->EnableWindow(1);
		pWnd = GetDlgItem(IDC_RADIO6);
		pWnd->EnableWindow(1);
	}
	else {
		pWnd = GetDlgItem(IDC_RADIO5);
		pWnd->EnableWindow(0);
		pWnd = GetDlgItem(IDC_RADIO6);
		pWnd->EnableWindow(0);
	} 

	//DI Pin3
	if ( DI_Valid & DIO_PIN3 ) {
		if ( DI_Status & DIO_PIN3 )	CheckRadioButton(IDC_RADIO7, IDC_RADIO8, IDC_RADIO7);   
		else						CheckRadioButton(IDC_RADIO7, IDC_RADIO8, IDC_RADIO8); 
		pWnd = GetDlgItem(IDC_RADIO7);
		pWnd->EnableWindow(1);
		pWnd = GetDlgItem(IDC_RADIO8);
		pWnd->EnableWindow(1);
	}
	else {
		pWnd = GetDlgItem(IDC_RADIO7);
		pWnd->EnableWindow(0);
		pWnd = GetDlgItem(IDC_RADIO8);
		pWnd->EnableWindow(0);
	} 

	//DI Pin4
	if ( DI_Valid & DIO_PIN4 ) {
		if ( DI_Status & DIO_PIN4 )	CheckRadioButton(IDC_RADIO9, IDC_RADIO10, IDC_RADIO9);   
		else						CheckRadioButton(IDC_RADIO9, IDC_RADIO10, IDC_RADIO10); 
		pWnd = GetDlgItem(IDC_RADIO9);
		pWnd->EnableWindow(1);
		pWnd = GetDlgItem(IDC_RADIO10);
		pWnd->EnableWindow(1);
	}
	else {
		pWnd = GetDlgItem(IDC_RADIO9);
		pWnd->EnableWindow(0);
		pWnd = GetDlgItem(IDC_RADIO10);
		pWnd->EnableWindow(0);
	} 

	//DI Pin5
	if ( DI_Valid & DIO_PIN5 ) {
		if ( DI_Status & DIO_PIN5 )	CheckRadioButton(IDC_RADIO11, IDC_RADIO12, IDC_RADIO11);   
		else						CheckRadioButton(IDC_RADIO11, IDC_RADIO12, IDC_RADIO12);   
		pWnd = GetDlgItem(IDC_RADIO11);
		pWnd->EnableWindow(1);
		pWnd = GetDlgItem(IDC_RADIO12);
		pWnd->EnableWindow(1);
	}
	else {
		pWnd = GetDlgItem(IDC_RADIO11);
		pWnd->EnableWindow(0);
		pWnd = GetDlgItem(IDC_RADIO12);
		pWnd->EnableWindow(0);
	} 

	//DI Pin6
	if ( DI_Valid & DIO_PIN6 ) {
		if ( DI_Status & DIO_PIN6 )	CheckRadioButton(IDC_RADIO13, IDC_RADIO14, IDC_RADIO13);   
		else						CheckRadioButton(IDC_RADIO13, IDC_RADIO14, IDC_RADIO14);   
		pWnd = GetDlgItem(IDC_RADIO13);
		pWnd->EnableWindow(1);
		pWnd = GetDlgItem(IDC_RADIO14);
		pWnd->EnableWindow(1);
	}
	else {
		pWnd = GetDlgItem(IDC_RADIO13);
		pWnd->EnableWindow(0);
		pWnd = GetDlgItem(IDC_RADIO14);
		pWnd->EnableWindow(0);
	} 

	//DI Pin7
	if ( DI_Valid & DIO_PIN7 ) {
		if ( DI_Status & DIO_PIN7 )	CheckRadioButton(IDC_RADIO15, IDC_RADIO16, IDC_RADIO15);   
		else						CheckRadioButton(IDC_RADIO15, IDC_RADIO16, IDC_RADIO16);  
		pWnd = GetDlgItem(IDC_RADIO15);
		pWnd->EnableWindow(1);
		pWnd = GetDlgItem(IDC_RADIO16);
		pWnd->EnableWindow(1);
	}
	else {
		pWnd = GetDlgItem(IDC_RADIO15);
		pWnd->EnableWindow(0);
		pWnd = GetDlgItem(IDC_RADIO16);
		pWnd->EnableWindow(0);
	} 
		
}

void CuAPI_test1Dlg::upadte_DO_Status(void)
{
CWnd* pWnd;
int DO_Status=0;
	AxGetDO(DO_Valid, &DO_Status );
	//DO Pin0
	if ( DO_Valid & DIO_PIN0 ) {
		if ( DO_Status & DIO_PIN0 )	CheckRadioButton(IDC_RADIO17, IDC_RADIO18, IDC_RADIO17);   
		else						CheckRadioButton(IDC_RADIO17, IDC_RADIO18, IDC_RADIO18);   
		pWnd = GetDlgItem(IDC_RADIO17);
		pWnd->EnableWindow(1);
		pWnd = GetDlgItem(IDC_RADIO18);
		pWnd->EnableWindow(1);
	}
	else {
		pWnd = GetDlgItem(IDC_RADIO17);
		pWnd->EnableWindow(0);
		pWnd = GetDlgItem(IDC_RADIO18);
		pWnd->EnableWindow(0);
	} 

	//DO Pin1
	if ( DO_Valid & DIO_PIN1 ) {
		if ( DO_Status & DIO_PIN1 )	CheckRadioButton(IDC_RADIO19, IDC_RADIO20, IDC_RADIO19);   
		else						CheckRadioButton(IDC_RADIO19, IDC_RADIO20, IDC_RADIO20); 
		pWnd = GetDlgItem(IDC_RADIO19);
		pWnd->EnableWindow(1);
		pWnd = GetDlgItem(IDC_RADIO20);
		pWnd->EnableWindow(1);
	}
	else {
		pWnd = GetDlgItem(IDC_RADIO19);
		pWnd->EnableWindow(0);
		pWnd = GetDlgItem(IDC_RADIO20);
		pWnd->EnableWindow(0);
	} 

	//DO Pin2
	if ( DO_Valid & DIO_PIN2 ) {
		if ( DO_Status & DIO_PIN2 )	CheckRadioButton(IDC_RADIO21, IDC_RADIO22, IDC_RADIO21);   
		else						CheckRadioButton(IDC_RADIO21, IDC_RADIO22, IDC_RADIO22);   
		pWnd = GetDlgItem(IDC_RADIO21);
		pWnd->EnableWindow(1);
		pWnd = GetDlgItem(IDC_RADIO22);
		pWnd->EnableWindow(1);
	}
	else {
		pWnd = GetDlgItem(IDC_RADIO21);
		pWnd->EnableWindow(0);
		pWnd = GetDlgItem(IDC_RADIO22);
		pWnd->EnableWindow(0);
	} 

	//DO Pin3
	if ( DO_Valid & DIO_PIN3 ) {
		if ( DO_Status & DIO_PIN3 )	CheckRadioButton(IDC_RADIO23, IDC_RADIO24, IDC_RADIO23);   
		else						CheckRadioButton(IDC_RADIO23, IDC_RADIO24, IDC_RADIO24);   
		pWnd = GetDlgItem(IDC_RADIO23);
		pWnd->EnableWindow(1);
		pWnd = GetDlgItem(IDC_RADIO24);
		pWnd->EnableWindow(1);
	}
	else {
		pWnd = GetDlgItem(IDC_RADIO23);
		pWnd->EnableWindow(0);
		pWnd = GetDlgItem(IDC_RADIO24);
		pWnd->EnableWindow(0);
	} 

	//DO Pin4
	if ( DO_Valid & DIO_PIN4 ) {
		if ( DO_Status & DIO_PIN4 )	CheckRadioButton(IDC_RADIO25, IDC_RADIO26, IDC_RADIO25);   
		else						CheckRadioButton(IDC_RADIO25, IDC_RADIO26, IDC_RADIO26);  
		pWnd = GetDlgItem(IDC_RADIO25);
		pWnd->EnableWindow(1);
		pWnd = GetDlgItem(IDC_RADIO26);
		pWnd->EnableWindow(1);
	}
	else {
		pWnd = GetDlgItem(IDC_RADIO25);
		pWnd->EnableWindow(0);
		pWnd = GetDlgItem(IDC_RADIO26);
		pWnd->EnableWindow(0);
	} 

	//DO Pin5
	if ( DO_Valid & DIO_PIN5 ) {
		if ( DO_Status & DIO_PIN5 )	CheckRadioButton(IDC_RADIO27, IDC_RADIO28, IDC_RADIO27);   
		else						CheckRadioButton(IDC_RADIO27, IDC_RADIO28, IDC_RADIO28);   
		pWnd = GetDlgItem(IDC_RADIO27);
		pWnd->EnableWindow(1);
		pWnd = GetDlgItem(IDC_RADIO28);
		pWnd->EnableWindow(1);
	}
	else {
		pWnd = GetDlgItem(IDC_RADIO27);
		pWnd->EnableWindow(0);
		pWnd = GetDlgItem(IDC_RADIO28);
		pWnd->EnableWindow(0);
	} 

	//DO Pin6
	if ( DO_Valid & DIO_PIN6 ) {
		if ( DO_Status & DIO_PIN6 )	CheckRadioButton(IDC_RADIO29, IDC_RADIO30, IDC_RADIO29);   
		else						CheckRadioButton(IDC_RADIO29, IDC_RADIO30, IDC_RADIO30);
		pWnd = GetDlgItem(IDC_RADIO29);
		pWnd->EnableWindow(1);
		pWnd = GetDlgItem(IDC_RADIO30);
		pWnd->EnableWindow(1);
	}
	else {
		pWnd = GetDlgItem(IDC_RADIO29);
		pWnd->EnableWindow(0);
		pWnd = GetDlgItem(IDC_RADIO30);
		pWnd->EnableWindow(0);
	} 

	//DO Pin7
	if ( DO_Valid & DIO_PIN7 ) {
		if ( DO_Status & DIO_PIN7 )	CheckRadioButton(IDC_RADIO31, IDC_RADIO32, IDC_RADIO31);   
		else						CheckRadioButton(IDC_RADIO31, IDC_RADIO32, IDC_RADIO32);  
		pWnd = GetDlgItem(IDC_RADIO31);
		pWnd->EnableWindow(1);
		pWnd = GetDlgItem(IDC_RADIO32);
		pWnd->EnableWindow(1);
	}
	else {
		pWnd = GetDlgItem(IDC_RADIO31);
		pWnd->EnableWindow(0);
		pWnd = GetDlgItem(IDC_RADIO32);
		pWnd->EnableWindow(0);
	} 

}

void CuAPI_test1Dlg::OnBnClickedRadio33()
{
	// TODO: Add your control notification handler code here
	CheckRadioButton(IDC_RADIO33, IDC_RADIO34, IDC_RADIO33);
}

void CuAPI_test1Dlg::OnBnClickedRadio34()
{
	// TODO: Add your control notification handler code here
	CheckRadioButton(IDC_RADIO33, IDC_RADIO34, IDC_RADIO34);
}

void CuAPI_test1Dlg::OnBnClickedRadio37()
{
	// TODO: Add your control notification handler code here
	CheckRadioButton(IDC_RADIO37, IDC_RADIO38, IDC_RADIO37);
}

void CuAPI_test1Dlg::OnBnClickedRadio38()
{
	// TODO: Add your control notification handler code here
	CheckRadioButton(IDC_RADIO37, IDC_RADIO38, IDC_RADIO38);
}

int WDT_Flag=0;
void CuAPI_test1Dlg::OnBnClickedWdtEnable()
{
CWnd* pWnd;
char xbuffer[10];
int	xData,xSelect;
	// TODO: Add your control notification handler code here
	if ( WDT_Flag==0 ) {
		WDT_Flag=1;
		pWnd = GetDlgItem(IDC_WDT_ENABLE);
		pWnd->SetWindowText("WDT Disable");
		//set WDT Timer Counter
		pWnd = GetDlgItem(IDC_TimerCnt_EDIT);
		pWnd->GetWindowTextA(xbuffer, 5);
		xData=atoi(xbuffer);
		if (xData > 255 ) xData=255;
		xSelect=GetCheckedRadioButton(IDC_RADIO33,IDC_RADIO34);
		if (xSelect == IDC_RADIO33 || xSelect == 0 )	xData |= 0x100;	 //set high byte != 0
		else											xData &= 0x00FF; //clear High byte 
		AxWDTSetCounter(xData);
		//set WDT Out pin
		xSelect=GetCheckedRadioButton(IDC_RADIO37,IDC_RADIO38);
		if (xSelect == IDC_RADIO38 || xSelect == 0 )	AxWDTOutputPin(bWDT_DISABLE);
		else											AxWDTOutputPin(bWDT_ENABLE);
		AxWDTexec(bWDT_ENABLE);


	}
	else {
		WDT_Flag=0;
		//AxWDTexec(bWDT_DISABLE);
		pWnd = GetDlgItem(IDC_WDT_ENABLE);
		pWnd->SetWindowText("WDT Enable");
		AxWDTexec(bWDT_DISABLE);
	}
}

void CuAPI_test1Dlg::OnBnClickedWdtReload()
{
	// TODO: Add your control notification handler code here
	AxWDTexec(bWDT_RELOAD);
}

void CuAPI_test1Dlg::OnBnClickedWdtStatus()
{
int repData=0;
	// TODO: Add your control notification handler code here
	AxWDTEvent(bWDT_EVENT, &repData);
	if (repData ) {
		CheckDlgButton(IDC_EVENT_CHECK, BST_CHECKED);
	}
	else {
		CheckDlgButton(IDC_EVENT_CHECK, BST_UNCHECKED);
	}
}

void CuAPI_test1Dlg::show_BIOSID_and_BoardID()
{
CWnd* pWnd;
SBC_DS2401 *SBC_BID;
BOOL bootRet;
//char biosid[10];
//
//	bootRet=AxSBC_BIOSID(biosid);
//
//	pWnd = GetDlgItem(IDC_BIOSID_EDIT);
//	if (bootRet) {
//		pWnd->SetWindowTextA((LPCTSTR)biosid);
//	}
//	else {
//		pWnd->SetWindowText("Unknow SBC Board");
//	}



	SBC_BID=(SBC_DS2401 *)_malloca(sizeof(SBC_DS2401));
	bootRet=AxGetBoardID(SBC_BID);

	if (bootRet) 
	{
		pWnd = GetDlgItem(IDC_BID_EDIT);
		pWnd->SetWindowTextA((LPCTSTR)(SBC_BID->sBoardID));

		pWnd = GetDlgItem(IDC_BIOSID_EDIT);
		char bVersion[6];
		for(int v=0; v<6; v++)
			bVersion[v] = SBC_BID->bBoardID[v];

		pWnd->SetWindowTextA((LPCTSTR)(bVersion));
	}
	else
	{
		pWnd = GetDlgItem(IDC_BID_EDIT);
		pWnd->SetWindowText("Not Supported");

		pWnd = GetDlgItem(IDC_BIOSID_EDIT);
		pWnd->SetWindowText("Not Supported");
	}
		
}
void CuAPI_test1Dlg::OnBnClickedEventClr()
{
int repData=0;
	// TODO: Add your control notification handler code here
	AxWDTEvent(bWDT_EVENT_CLR, &repData);
}

void CuAPI_test1Dlg::OnCbnSelchangeCombo1()
{
	// TODO: Add your control notification handler code here
}


void CuAPI_test1Dlg::OnBnClickedLoading()
{
	// TODO: Add your control notification handler code here
CWnd* pWnd;
char xbuffer[25];
BOOL bRet;
	pWnd = GetDlgItem(IDC_LibraryInput);
	pWnd->GetWindowText(xbuffer, 20);
	bRet=AxBoardLoadLibrary(xbuffer);
	pWnd = GetDlgItem(IDC_LoadStatus);
	if (bRet) pWnd->SetWindowText("OK");
	else	  pWnd->SetWindowText("Fail");
	if (bRet) {
		//update DIO Current Direction Setting
			AxGetDIOValidPin(1, &DI_Valid);
			AxGetDIOValidPin(2, &DO_Valid);
		//set Output check BOX enabled
			if ( DO_Valid & DIO_PIN0 ) 	CheckDlgButton(IDC_CHECK50,BST_CHECKED);
			if ( DO_Valid & DIO_PIN1 ) 	CheckDlgButton(IDC_CHECK51,BST_CHECKED);
			if ( DO_Valid & DIO_PIN2 ) 	CheckDlgButton(IDC_CHECK52,BST_CHECKED);
			if ( DO_Valid & DIO_PIN3 ) 	CheckDlgButton(IDC_CHECK53,BST_CHECKED);
			if ( DO_Valid & DIO_PIN4 ) 	CheckDlgButton(IDC_CHECK54,BST_CHECKED);
			if ( DO_Valid & DIO_PIN5 ) 	CheckDlgButton(IDC_CHECK55,BST_CHECKED);
			if ( DO_Valid & DIO_PIN6 ) 	CheckDlgButton(IDC_CHECK56,BST_CHECKED);
			if ( DO_Valid & DIO_PIN7 ) 	CheckDlgButton(IDC_CHECK57,BST_CHECKED);
	}

}


void CuAPI_test1Dlg::OnBnClickedCheck57()
{
	// TODO: Add your control notification handler code here
int pinData;
UINT uiRet;
	uiRet=IsDlgButtonChecked(IDC_CHECK57);
	if (uiRet == BST_CHECKED)  pinData=(int)DIO7_OUTPUT;
	else					   pinData=(int)DIO7_INPUT	;

	AxSetDIODirection(DIO_PIN7, &pinData);
}

void CuAPI_test1Dlg::OnBnClickedCheck56()
{
	// TODO: Add your control notification handler code here
int pinData;
UINT uiRet;
	uiRet=IsDlgButtonChecked(IDC_CHECK56);
	if (uiRet == BST_CHECKED)  pinData=(int)DIO6_OUTPUT;
	else					   pinData=(int)DIO6_INPUT	;

	AxSetDIODirection(DIO_PIN6, &pinData);
}

void CuAPI_test1Dlg::OnBnClickedCheck55()
{
	// TODO: Add your control notification handler code here
int pinData;
UINT uiRet;
	uiRet=IsDlgButtonChecked(IDC_CHECK55);
	if (uiRet == BST_CHECKED)  pinData=(int)DIO5_OUTPUT;
	else					   pinData=(int)DIO5_INPUT	;

	AxSetDIODirection(DIO_PIN5, &pinData);
}

void CuAPI_test1Dlg::OnBnClickedCheck54()
{
	// TODO: Add your control notification handler code here
int pinData;
UINT uiRet;
	uiRet=IsDlgButtonChecked(IDC_CHECK54);
	if (uiRet == BST_CHECKED)  pinData=(int)DIO4_OUTPUT;
	else					   pinData=(int)DIO4_INPUT	;

	AxSetDIODirection(DIO_PIN4, &pinData);
}

void CuAPI_test1Dlg::OnBnClickedCheck53()
{
	// TODO: Add your control notification handler code here
int pinData;
UINT uiRet;
	uiRet=IsDlgButtonChecked(IDC_CHECK53);
	if (uiRet == BST_CHECKED)  pinData=(int)DIO3_OUTPUT;
	else					   pinData=(int)DIO3_INPUT	;

	AxSetDIODirection(DIO_PIN3, &pinData);
}

void CuAPI_test1Dlg::OnBnClickedCheck52()
{
	// TODO: Add your control notification handler code here
int pinData;
UINT uiRet;
	uiRet=IsDlgButtonChecked(IDC_CHECK52);
	if (uiRet == BST_CHECKED)  pinData=(int)DIO2_OUTPUT;
	else					   pinData=(int)DIO2_INPUT	;

	AxSetDIODirection(DIO_PIN2, &pinData);
}

void CuAPI_test1Dlg::OnBnClickedCheck51()
{
	// TODO: Add your control notification handler code here
int pinData;
UINT uiRet;
	uiRet=IsDlgButtonChecked(IDC_CHECK51);
	if (uiRet == BST_CHECKED)  pinData=(int)DIO1_OUTPUT;
	else					   pinData=(int)DIO1_INPUT	;

	AxSetDIODirection(DIO_PIN1, &pinData);
}

void CuAPI_test1Dlg::OnBnClickedCheck50()
{
	// TODO: Add your control notification handler code here
int pinData;
UINT uiRet;
	uiRet=IsDlgButtonChecked(IDC_CHECK50);
	if (uiRet == BST_CHECKED)  pinData=(int)DIO0_OUTPUT;
	else					   pinData=(int)DIO0_INPUT	;

	AxSetDIODirection(DIO_PIN0, &pinData);
}

void CuAPI_test1Dlg::OnEnChangeLibraryinput()
{
	// TODO:  If this is a RICHEDIT control, the control will not
	// send this notification unless you override the CDialog::OnInitDialog()
	// function and call CRichEditCtrl().SetEventMask()
	// with the ENM_CHANGE flag ORed into the mask.

	// TODO:  Add your control notification handler code here
}

