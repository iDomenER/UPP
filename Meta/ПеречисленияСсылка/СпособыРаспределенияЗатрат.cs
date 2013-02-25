﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	///<summary>
	///(Общ)
	///</summary>
	[DataContract]
	public enum СпособыРаспределенияЗатрат
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"50fd2ee5-83de-4b31-bf56-57a3508ec7d1\", \"Представление\":\"ПоОбъемуВыпуска\"}")]
		ПоОбъемуВыпуска = 0,//По объему выпуска
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"3d94e960-07a7-4e0d-b5a4-9b77d7750601\", \"Представление\":\"ПоПлановойСебестоимости\"}")]
		ПоПлановойСебестоимости = 1,//По плановой себестоимости
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"72f52a03-27bb-425b-920f-31315a3ed40e\", \"Представление\":\"ПоОплатеТруда\"}")]
		ПоОплатеТруда = 2,//По оплате труда
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"f128cc68-8145-402a-ab7f-f6a33bad89ae\", \"Представление\":\"ПоМатериальнымЗатратам\"}")]
		ПоМатериальнымЗатратам = 3,//По материальным затратам
		[EnumMember(Value = "{\"Ссылка\":\"cd817294-7c09-42ff-a06f-af413ef34e0e\", \"Представление\":\"НеРаспределять\"}")]
		НеРаспределять = 4,//Не распределять
	}
	public static partial class СпособыРаспределенияЗатрат_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ПоОбъемуВыпуска = new Guid("a35756bf-8e50-d1c7-4b31-83de50fd2ee5");//По объему выпуска
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ПоПлановойСебестоимости = new Guid("779ba4b5-75d7-0106-4e0d-07a73d94e960");//По плановой себестоимости
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ПоОплатеТруда = new Guid("31310f92-3e5a-0ed4-425b-27bb72f52a03");//По оплате труда
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ПоМатериальнымЗатратам = new Guid("a3f67fab-ad3b-ae89-402a-8145f128cc68");//По материальным затратам
		public static readonly Guid НеРаспределять = new Guid("41af6fa0-f33e-0e4e-42ff-7c09cd817294");//Не распределять
		public static СпособыРаспределенияЗатрат Получить(this СпособыРаспределенияЗатрат Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СпособыРаспределенияЗатрат Получить(this СпособыРаспределенияЗатрат Значение, Guid Ссылка)
		{
			if(Ссылка == ПоОбъемуВыпуска)
			{
				return СпособыРаспределенияЗатрат.ПоОбъемуВыпуска;
			}
			else if(Ссылка == ПоПлановойСебестоимости)
			{
				return СпособыРаспределенияЗатрат.ПоПлановойСебестоимости;
			}
			else if(Ссылка == ПоОплатеТруда)
			{
				return СпособыРаспределенияЗатрат.ПоОплатеТруда;
			}
			else if(Ссылка == ПоМатериальнымЗатратам)
			{
				return СпособыРаспределенияЗатрат.ПоМатериальнымЗатратам;
			}
			else if(Ссылка == НеРаспределять)
			{
				return СпособыРаспределенияЗатрат.НеРаспределять;
			}
			return СпособыРаспределенияЗатрат.ПустаяСсылка;
		}
		public static byte[] Ключ(this СпособыРаспределенияЗатрат Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СпособыРаспределенияЗатрат Значение)
		{
			switch (Значение)
			{
				case СпособыРаспределенияЗатрат.ПоОбъемуВыпуска: return ПоОбъемуВыпуска;
				case СпособыРаспределенияЗатрат.ПоПлановойСебестоимости: return ПоПлановойСебестоимости;
				case СпособыРаспределенияЗатрат.ПоОплатеТруда: return ПоОплатеТруда;
				case СпособыРаспределенияЗатрат.ПоМатериальнымЗатратам: return ПоМатериальнымЗатратам;
				case СпособыРаспределенияЗатрат.НеРаспределять: return НеРаспределять;
			}
			return Guid.Empty;
		}
	}
}