using System;

namespace FormsReferenceApp.Commons
{

	public static class FRAConstants
	{

        public const string KEnvironmentsFileNameString = "Environments.json";
        public const string KFingerPrintMessageKeyString = "FingerPrintMessage";
        public const string KDateFormatString = "mm/dd/yyyy";				
		public const string KGenericErrorMessageMessageTextString = "GenericErrorMessage";

        public const int    KMaxThreadCount = 5;
        public static       DateTime KReferenceDate = new DateTime(1970, 1, 1, 0, 0, 0);		
		public const int    KGenericErrorCode = 4;
        public const float  KDefaultCellHeight = 120.0F;

    }
}
