﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	///<summary>
	///(Регл)
	///</summary>
	[DataContract]
	public enum КатегорииДолжностейДляСтатистическогоУчета
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"10a472db-2ced-4055-abed-3a318bb35342\", \"Представление\":\"Руководители\"}")]
		Руководители = 0,
		[EnumMember(Value = "{\"Ссылка\":\"4b6925f3-f942-4746-ac88-1e961c086d7b\", \"Представление\":\"Специалисты\"}")]
		Специалисты = 1,
		[EnumMember(Value = "{\"Ссылка\":\"6b3cae17-3713-4687-ba70-6cab581092a1\", \"Представление\":\"НаучныеИПедагогическиеРаботники\"}")]
		НаучныеИПедагогическиеРаботники = 2,//Научные и научно-педагогические работники
		[EnumMember(Value = "{\"Ссылка\":\"9b69522f-c396-432c-b1f2-2ac577b80fb4\", \"Представление\":\"ДругиеСлужащие\"}")]
		ДругиеСлужащие = 3,//Другие служащие
		[EnumMember(Value = "{\"Ссылка\":\"aa088298-dd1c-49d8-9af3-4cb9f0616d45\", \"Представление\":\"Рабочие\"}")]
		Рабочие = 4,
	}
	public static partial class КатегорииДолжностейДляСтатистическогоУчета_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Руководители = new Guid("313aedab-b38b-4253-4055-2ced10a472db");
		public static readonly Guid Специалисты = new Guid("961e88ac-081c-7b6d-4746-f9424b6925f3");
		public static readonly Guid НаучныеИПедагогическиеРаботники = new Guid("ab6c70ba-1058-a192-4687-37136b3cae17");//Научные и научно-педагогические работники
		public static readonly Guid ДругиеСлужащие = new Guid("c52af2b1-b877-b40f-432c-c3969b69522f");//Другие служащие
		public static readonly Guid Рабочие = new Guid("b94cf39a-61f0-456d-49d8-dd1caa088298");
		public static КатегорииДолжностейДляСтатистическогоУчета Получить(this КатегорииДолжностейДляСтатистическогоУчета Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static КатегорииДолжностейДляСтатистическогоУчета Получить(this КатегорииДолжностейДляСтатистическогоУчета Значение, Guid Ссылка)
		{
			if(Ссылка == Руководители)
			{
				return КатегорииДолжностейДляСтатистическогоУчета.Руководители;
			}
			else if(Ссылка == Специалисты)
			{
				return КатегорииДолжностейДляСтатистическогоУчета.Специалисты;
			}
			else if(Ссылка == НаучныеИПедагогическиеРаботники)
			{
				return КатегорииДолжностейДляСтатистическогоУчета.НаучныеИПедагогическиеРаботники;
			}
			else if(Ссылка == ДругиеСлужащие)
			{
				return КатегорииДолжностейДляСтатистическогоУчета.ДругиеСлужащие;
			}
			else if(Ссылка == Рабочие)
			{
				return КатегорииДолжностейДляСтатистическогоУчета.Рабочие;
			}
			return КатегорииДолжностейДляСтатистическогоУчета.ПустаяСсылка;
		}
		public static byte[] Ключ(this КатегорииДолжностейДляСтатистическогоУчета Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this КатегорииДолжностейДляСтатистическогоУчета Значение)
		{
			switch (Значение)
			{
				case КатегорииДолжностейДляСтатистическогоУчета.Руководители: return Руководители;
				case КатегорииДолжностейДляСтатистическогоУчета.Специалисты: return Специалисты;
				case КатегорииДолжностейДляСтатистическогоУчета.НаучныеИПедагогическиеРаботники: return НаучныеИПедагогическиеРаботники;
				case КатегорииДолжностейДляСтатистическогоУчета.ДругиеСлужащие: return ДругиеСлужащие;
				case КатегорииДолжностейДляСтатистическогоУчета.Рабочие: return Рабочие;
			}
			return Guid.Empty;
		}
	}
}