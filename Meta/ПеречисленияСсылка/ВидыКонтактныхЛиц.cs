﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum ВидыКонтактныхЛиц
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"7d07649c-efa7-4df1-a6ec-822411354b1b\", \"Представление\":\"КонтактноеЛицоКонтрагента\"}")]
		КонтактноеЛицоКонтрагента = 0,//Контактное лицо контрагента
		[EnumMember(Value = "{\"Ссылка\":\"e9f6b899-ac8d-4ab4-9507-ce37eb0177f1\", \"Представление\":\"ПрочееКонтактноеЛицо\"}")]
		ПрочееКонтактноеЛицо = 1,//Прочее контактное лицо
		[EnumMember(Value = "{\"Ссылка\":\"0106b669-1e61-4895-9253-3f0f6dcedbeb\", \"Представление\":\"ЛичныйКонтакт\"}")]
		ЛичныйКонтакт = 2,//Личный контакт
	}
	public static partial class ВидыКонтактныхЛиц_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid КонтактноеЛицоКонтрагента = new Guid("2482eca6-3511-1b4b-4df1-efa77d07649c");//Контактное лицо контрагента
		public static readonly Guid ПрочееКонтактноеЛицо = new Guid("37ce0795-01eb-f177-4ab4-ac8de9f6b899");//Прочее контактное лицо
		public static readonly Guid ЛичныйКонтакт = new Guid("0f3f5392-ce6d-ebdb-4895-1e610106b669");//Личный контакт
		public static ВидыКонтактныхЛиц Получить(this ВидыКонтактныхЛиц Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыКонтактныхЛиц Получить(this ВидыКонтактныхЛиц Значение, Guid Ссылка)
		{
			if(Ссылка == КонтактноеЛицоКонтрагента)
			{
				return ВидыКонтактныхЛиц.КонтактноеЛицоКонтрагента;
			}
			else if(Ссылка == ПрочееКонтактноеЛицо)
			{
				return ВидыКонтактныхЛиц.ПрочееКонтактноеЛицо;
			}
			else if(Ссылка == ЛичныйКонтакт)
			{
				return ВидыКонтактныхЛиц.ЛичныйКонтакт;
			}
			return ВидыКонтактныхЛиц.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыКонтактныхЛиц Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыКонтактныхЛиц Значение)
		{
			switch (Значение)
			{
				case ВидыКонтактныхЛиц.КонтактноеЛицоКонтрагента: return КонтактноеЛицоКонтрагента;
				case ВидыКонтактныхЛиц.ПрочееКонтактноеЛицо: return ПрочееКонтактноеЛицо;
				case ВидыКонтактныхЛиц.ЛичныйКонтакт: return ЛичныйКонтакт;
			}
			return Guid.Empty;
		}
	}
}