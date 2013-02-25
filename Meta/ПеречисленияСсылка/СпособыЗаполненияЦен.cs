﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	///<summary>
	///(Упр)
	///</summary>
	[DataContract]
	public enum СпособыЗаполненияЦен
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"7b0af51d-d5ce-4722-ab22-17b3d32c8499\", \"Представление\":\"ПоЦенамНоменклатуры\"}")]
		ПоЦенамНоменклатуры = 0,//По ценам номенклатуры
	///<summary>
	///(Упр)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"9da4f1a3-873e-4ddd-a877-32e67b68c7c0\", \"Представление\":\"ПоЦенамНоменклатурыКонтрагентов\"}")]
		ПоЦенамНоменклатурыКонтрагентов = 1,//По ценам номенклатуры контрагентов
	///<summary>
	///(Упр)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"990b145a-19ed-4e86-8225-4d3bb0f60c88\", \"Представление\":\"ПоНоменклатуреИЦенамКонтрагентов\"}")]
		ПоНоменклатуреИЦенамКонтрагентов = 2,//По номенклатуре и ценам контрагентов
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"539c814e-3343-4663-8312-abca1842f063\", \"Представление\":\"ПоРозничнымЦенам\"}")]
		ПоРозничнымЦенам = 3,//По розничным ценам
		[EnumMember(Value = "{\"Ссылка\":\"216d83e4-bba7-4b48-8e53-e5b6b8e7d60d\", \"Представление\":\"ПоПродажнымЦенам\"}")]
		ПоПродажнымЦенам = 4,//По продажным ценам
	}
	public static partial class СпособыЗаполненияЦен_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ПоЦенамНоменклатуры = new Guid("b31722ab-2cd3-9984-4722-d5ce7b0af51d");//По ценам номенклатуры
		///<summary>
		///(Упр)
		///</summary>
		public static readonly Guid ПоЦенамНоменклатурыКонтрагентов = new Guid("e63277a8-687b-c0c7-4ddd-873e9da4f1a3");//По ценам номенклатуры контрагентов
		///<summary>
		///(Упр)
		///</summary>
		public static readonly Guid ПоНоменклатуреИЦенамКонтрагентов = new Guid("3b4d2582-f6b0-880c-4e86-19ed990b145a");//По номенклатуре и ценам контрагентов
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ПоРозничнымЦенам = new Guid("caab1283-4218-63f0-4663-3343539c814e");//По розничным ценам
		public static readonly Guid ПоПродажнымЦенам = new Guid("b6e5538e-e7b8-0dd6-4b48-bba7216d83e4");//По продажным ценам
		public static СпособыЗаполненияЦен Получить(this СпособыЗаполненияЦен Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СпособыЗаполненияЦен Получить(this СпособыЗаполненияЦен Значение, Guid Ссылка)
		{
			if(Ссылка == ПоЦенамНоменклатуры)
			{
				return СпособыЗаполненияЦен.ПоЦенамНоменклатуры;
			}
			else if(Ссылка == ПоЦенамНоменклатурыКонтрагентов)
			{
				return СпособыЗаполненияЦен.ПоЦенамНоменклатурыКонтрагентов;
			}
			else if(Ссылка == ПоНоменклатуреИЦенамКонтрагентов)
			{
				return СпособыЗаполненияЦен.ПоНоменклатуреИЦенамКонтрагентов;
			}
			else if(Ссылка == ПоРозничнымЦенам)
			{
				return СпособыЗаполненияЦен.ПоРозничнымЦенам;
			}
			else if(Ссылка == ПоПродажнымЦенам)
			{
				return СпособыЗаполненияЦен.ПоПродажнымЦенам;
			}
			return СпособыЗаполненияЦен.ПустаяСсылка;
		}
		public static byte[] Ключ(this СпособыЗаполненияЦен Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СпособыЗаполненияЦен Значение)
		{
			switch (Значение)
			{
				case СпособыЗаполненияЦен.ПоЦенамНоменклатуры: return ПоЦенамНоменклатуры;
				case СпособыЗаполненияЦен.ПоЦенамНоменклатурыКонтрагентов: return ПоЦенамНоменклатурыКонтрагентов;
				case СпособыЗаполненияЦен.ПоНоменклатуреИЦенамКонтрагентов: return ПоНоменклатуреИЦенамКонтрагентов;
				case СпособыЗаполненияЦен.ПоРозничнымЦенам: return ПоРозничнымЦенам;
				case СпособыЗаполненияЦен.ПоПродажнымЦенам: return ПоПродажнымЦенам;
			}
			return Guid.Empty;
		}
	}
}