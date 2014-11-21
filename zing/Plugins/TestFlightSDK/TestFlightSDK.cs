//#if TESTFLIGHT_SDK_ENABLED
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;

[System.Serializable]
public class TestFlightSDK 
{
#if TESTFLIGHT_SDK_ENABLED && UNITY_IPHONE && (!UNITY_EDITOR)
	[DllImport ("__Internal")]
	private static extern void TestFlight_SubmitFeedback(string feedbackString);
	public static void SubmitFeedback(string feedbackString)
	{
		TestFlight_SubmitFeedback(feedbackString);
	}
	
	[DllImport ("__Internal")]
	private static extern void TestFlight_OpenFeedbackView();
	public static void OpenFeedbackView() 
	{
		TestFlight_OpenFeedbackView();
	}
	
	[DllImport ("__Internal")]
	private static extern void TestFlight_PassCheckpoint(string checkpointName);
	public static void PassCheckpoint(string checkpointName) 
	{
		TestFlight_PassCheckpoint(checkpointName);
	}	
	
	[DllImport ("__Internal")]
	private static extern void TestFlight_AddCustomEnvironmentInformation(string information, string forKey);
	public static void AddCustomEnvironmentInformation(string information, string forKey) 
	{
		TestFlight_AddCustomEnvironmentInformation(information, forKey);
	}
	
	[DllImport ("__Internal")]
	private static extern void TestFlight_TFLog(string message);
	public static void TFLog(string message)
	{
		TestFlight_TFLog(message);
	}
#else
	public static void OpenFeedbackView() {}
	public static void PassCheckpoint(string checkpointName) {}
	public static void AddCustomEnvironmentInformation(string information, string forKey) {}
	public static void SubmitFeedback(string feedbackString) {}
	public static void TFLog(string message) {}
#endif
}