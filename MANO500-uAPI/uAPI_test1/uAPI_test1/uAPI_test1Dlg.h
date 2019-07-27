// uAPI_test1Dlg.h : header file
//

#pragma once


// CuAPI_test1Dlg dialog
class CuAPI_test1Dlg : public CDialog
{
// Construction
public:
	CuAPI_test1Dlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	enum { IDD = IDD_UAPI_TEST1_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support


// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnBnClickedOk();

	afx_msg void OnBnClickedDoDemo();
	afx_msg void upadte_DI_Status();
	afx_msg void upadte_DO_Status();
	afx_msg void show_BIOSID_and_BoardID();
	
	
	afx_msg void OnBnClickedRadio33();
	afx_msg void OnBnClickedRadio34();
	afx_msg void OnBnClickedRadio37();
	afx_msg void OnBnClickedRadio38();
	afx_msg void OnEnChangeTimercntEdit();
	afx_msg void OnBnClickedWdtEnable();
	afx_msg void OnBnClickedWdtReload();
	afx_msg void OnBnClickedWdtStatus();
	afx_msg void OnBnClickedEventClr();
	afx_msg void OnCbnSelchangeCombo1();
	afx_msg void OnBnClickedLoading();
	afx_msg void OnBnClickedCheck57();
	afx_msg void OnBnClickedCheck56();
	afx_msg void OnBnClickedCheck55();
	afx_msg void OnBnClickedCheck54();
	afx_msg void OnBnClickedCheck53();
	afx_msg void OnBnClickedCheck52();
	afx_msg void OnBnClickedCheck51();
	afx_msg void OnBnClickedCheck50();
	afx_msg void OnEnChangeLibraryinput();
};
