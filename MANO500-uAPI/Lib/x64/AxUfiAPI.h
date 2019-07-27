
// The following ifdef block is the standard way of creating macros which make exporting 
// from a DLL simpler. All files within this DLL are compiled with the ICO1000_EXPORTS
// symbol defined on the command line. this symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see 
// ICO1000_API functions as being imported from a DLL, wheras this DLL sees symbols
// defined with this macro as being exported.
//#ifdef ICO1000_EXPORTS
//#define ICO1000_API __declspec(dllexport)
//#else
//#define AxHWInfo_API __declspec(dllimport)
//#endif

#ifndef AxHWInfo_H
#define AxHWInfo_H

#define	ID_SBC86831			1
#define	ID_SBC84620			2
#define	ID_SBC86837			3


// Windows OS Version define
//32bit OS
#define	OS_WIN95		0x0001
#define	OS_WIN98		0x0002
#define	OS_WINME		0x0003
#define	OS_WIN2000		0x0004
#define	OS_WINNT		0x0005
#define	OS_WINXP		0x0006
#define	OS_VISTA		0x0007
#define	OS_SERVER2003	0x0008
#define OS_WINDOWS7		0x0009
//64bit OS
#define	OS64_WINXP		0x0101
#define	OS64_VISTA		0x0102
#define	OS64_WINDOWS7	0x0103


//Digital IO pin define
#define	DIO_PIN0			0x01
#define	DIO_PIN1			0x02
#define	DIO_PIN2			0x04
#define	DIO_PIN3			0x08
#define	DIO_PIN4			0x10
#define	DIO_PIN5			0x20
#define	DIO_PIN6			0x40
#define	DIO_PIN7			0x80
// DIO Direction Setting
#define	DIO0_OUTPUT			0x00
#define DIO0_INPUT			0x01
#define	DIO1_OUTPUT			0x00
#define DIO1_INPUT			0x02
#define	DIO2_OUTPUT			0x00
#define DIO2_INPUT			0x04
#define	DIO3_OUTPUT			0x00
#define DIO3_INPUT			0x08
#define	DIO4_OUTPUT			0x00
#define DIO4_INPUT			0x10
#define	DIO5_OUTPUT			0x00
#define DIO5_INPUT			0x20
#define	DIO6_OUTPUT			0x00
#define DIO6_INPUT			0x40
#define	DIO7_OUTPUT			0x00
#define DIO7_INPUT			0x80

//Watch Dog Timer define
#define	bWDT_MINUTE		0x0100
#define	bWDT_SECOND		0x0000
#define bWDT_ENABLE		0x0001
#define	bWDT_DISABLE	0x0002
#define	bWDT_RELOAD		0x0003
#define	bWDT_EVENT		0x0004
#define	bWDT_EVENT_CLR	0x0005

//*******************************
//****  Smart Battery Kit define
//*******************************
//AxGetBatteryKitStatus
#define fExist_BatteryCharger	0x00000001		//bit 0~7 BatteryKit Exist
#define	fExist_BatteryData		0x00000002
#define	fExist_BatterySelector	0x00000004
#define	fChargerInhibit			0x00000100		//bit 8~15 charger status
#define	fAC_Present				0x00000200
#define fBattery_Present		0x00000400
#define	fBatteryFullCharged		0x00010000		//bit 16~23 battery status
#define	fBatteryDischarging		0x00020000
#define fBatteryOverTempAlarm	0x00040000
//												//bit 24~31 selector status
//AxSetChargerMode
#define	bInhibitCharge			0x0001		
#define	bEnablePolling			0x0002
#define	bPowerOnDefault			0x0004
#define	bChargingToZero			0x0008

//AxSetBatteryMode
#define	bEnableInternalCharger		0x0100			//bit8		
#define	bPrimaryBattery				0x0200			//bit9
#define	bDisableAlarmBroadcasts		0x2000			//bit13
#define	bDisableBroadcastsCharging	0x4000			//bit14,disable charging vlotage and current broadcasts
#define	bReportWattMode				0x8000			//bit15, set mA to mW

typedef struct BATTERY_MANUFACTURER {
	wchar_t		sManufacturerName[33];
	wchar_t		sDeviceName[33];
	wchar_t		sDeviceChemistry[33];
}AxBatteryManufacturer;

typedef struct BATTERY_CAPACITY {
	unsigned short	PercentageOfFull;
	unsigned short	PercentageOfDesign;
	unsigned short	RemainingCapacity;
	unsigned short	FullChargeCapacity;
	unsigned short	DesignCapacity;
}AxBatteryCapacity;

typedef struct BATTERY_RUNTIME {
	short			PercentageOfFull;
	short			BatteryCurrent;
	short			BatteryVoltage;
	unsigned short	RunTimeToEmpty;
	unsigned short	Temperature;
}AxBatteryRuntime;


typedef struct SBC_DS2401 {
	long double		dlBoardID;
	unsigned char	bBoardID[6];
	unsigned char	sBoardID[13];
}sbc_ds2401;


#ifdef AXuAPI_DLL
#define AXuAPI _declspec(dllexport)
#else
#define AXuAPI _declspec(dllimport)
#endif

extern "C"
{
/** Hardware Library Control Function **/
AXuAPI BOOL __stdcall AxBoardLoadLibrary(char *dllname);
AXuAPI BOOL __stdcall AxBoardReleaseLibrary(void);
/*************** Needs Boadr Level Library -Start- ***************/
/** Hardware Monitor Function ***/
AXuAPI BOOL __stdcall AxGetCPUTemp(float * fValue);
AXuAPI BOOL __stdcall AxGetSYSTemp(float * fValue);
AXuAPI BOOL __stdcall AxGetGMCHTemp(float * fValue);
AXuAPI BOOL __stdcall AxGetCPUFAN(float * fValue);
AXuAPI BOOL __stdcall AxGetSYSFAN(float * fValue);
AXuAPI BOOL __stdcall AxGetGMCHFAN(float * fValue);
AXuAPI BOOL __stdcall AxGetCPUVcore(float * fValue);
AXuAPI BOOL __stdcall AxGetNBVTT(float * fValue);
AXuAPI BOOL __stdcall AxGet3V(float * fValue);
AXuAPI BOOL __stdcall AxGet5V(float * fValue);
AXuAPI BOOL __stdcall AxGet12V(float * fValue);
AXuAPI BOOL __stdcall AxGetNeg5V(float * fValue);
AXuAPI BOOL __stdcall AxGetNeg12V(float * fValue);
AXuAPI BOOL __stdcall AxGetVbat(float * fValue);
/** Digital IO Function **/
AXuAPI BOOL __stdcall AxGetDI(int pin, int *pinData);
AXuAPI BOOL __stdcall AxGetDO(int pin, int *pinData);
AXuAPI BOOL __stdcall AxSetDO(int pin, int *pinData);
AXuAPI BOOL __stdcall AxGetDIOValidPin(int pin, int *pinData);
AXuAPI BOOL __stdcall AxSetDIODirection(int pin, int *pinData);
/** Watch dog Timer Function **/
AXuAPI BOOL __stdcall AxWDTSetCounter(int timeCounter);
AXuAPI BOOL __stdcall AxWDTexec(int subFunction);
AXuAPI BOOL __stdcall AxWDTOutputPin(int sunFunction);
AXuAPI BOOL __stdcall AxWDTEvent(int sunFunction, int *repData);
/*************** Needs Boadr Level Library -End- ******************/
/** Unique Board ID Function **/
AXuAPI BOOL __stdcall AxGetBoardID(SBC_DS2401 *sbc_bid);
/* Utilities Function **/
AXuAPI int __stdcall  AxOS_Version(void);
AXuAPI BOOL __stdcall AxSystemReboot(void);
AXuAPI BOOL __stdcall AxSystemShutdown(void);
AXuAPI BOOL __stdcall AxSBC_BIOSID(char *biosid);
/* SMBus I2C Function */
AXuAPI BOOL __stdcall AxQueryI2CDevice(UCHAR I2CAddress);
AXuAPI BOOL __stdcall AxReadI2CByte(UCHAR I2CAddress, UCHAR I2CRegister, LPBYTE pDataBuffer);
AXuAPI BOOL __stdcall AxReadI2CWord(UCHAR I2CAddress, UCHAR I2CRegister, LPBYTE pDataBuffer);
AXuAPI BOOL __stdcall AxWriteI2CByte(UCHAR I2CAddress, UCHAR I2CRegister, LPBYTE pDataBuffer);
AXuAPI BOOL __stdcall AxWriteI2CWord(UCHAR I2CAddress, UCHAR I2CRegister, LPBYTE pDataBuffer);
AXuAPI BOOL __stdcall AxGetSMBusAddress(USHORT * pSMBusAddress);
AXuAPI BOOL __stdcall AxReadI2CBlock(UCHAR I2CAddress, UCHAR I2CRegister, LPBYTE pDataBuffer);
/* Smart Battery Kit Function */
AXuAPI BOOL __stdcall AxGetBatteryKitStatus(ULONG * plBatteryKitStatus);
AXuAPI BOOL __stdcall AxGetBatteryManufacturer(AxBatteryManufacturer * pBatteryManufacturer);
AXuAPI BOOL __stdcall AxGetBatteryCapacity(AxBatteryCapacity * pBatteryCapacity);
AXuAPI BOOL __stdcall AxGetBatteryRuntime(AxBatteryRuntime * pBatteryRuntime);
AXuAPI BOOL __stdcall AxSetChargerMode(USHORT wChargerMode);
AXuAPI BOOL __stdcall AxSetBatteryMode(USHORT wBatteryMode);
AXuAPI BOOL __stdcall AxGetBatteryMode(USHORT * pwBatteryMode);

}
#endif

