﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum ТипыЗаявленияАбонентаСпецоператораСвязи
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"8e3c6854-cd12-463b-82af-83987033006d\", \"Представление\":\"Первичное\"}")]
		Первичное = 0,
		[EnumMember(Value = "{\"Ссылка\":\"ba6e1177-55cf-4ec0-a77f-979fd31d92f2\", \"Представление\":\"Изменение\"}")]
		Изменение = 1,
		[EnumMember(Value = "{\"Ссылка\":\"bdafbe10-b1ca-4c5a-8c99-07da69cae943\", \"Представление\":\"Пролонгация\"}")]
		Пролонгация = 2,
		[EnumMember(Value = "{\"Ссылка\":\"cd08f9d2-95e2-46d0-a3fb-0ee5ff0df9f0\", \"Представление\":\"Восстановление\"}")]
		Восстановление = 3,
	}
	public static partial class ТипыЗаявленияАбонентаСпецоператораСвязи_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Первичное = new Guid("9883af82-3370-6d00-463b-cd128e3c6854");
		public static readonly Guid Изменение = new Guid("9f977fa7-1dd3-f292-4ec0-55cfba6e1177");
		public static readonly Guid Пролонгация = new Guid("da07998c-ca69-43e9-4c5a-b1cabdafbe10");
		public static readonly Guid Восстановление = new Guid("e50efba3-0dff-f0f9-46d0-95e2cd08f9d2");
		public static ТипыЗаявленияАбонентаСпецоператораСвязи Получить(this ТипыЗаявленияАбонентаСпецоператораСвязи Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ТипыЗаявленияАбонентаСпецоператораСвязи Получить(this ТипыЗаявленияАбонентаСпецоператораСвязи Значение, Guid Ссылка)
		{
			if(Ссылка == Первичное)
			{
				return ТипыЗаявленияАбонентаСпецоператораСвязи.Первичное;
			}
			else if(Ссылка == Изменение)
			{
				return ТипыЗаявленияАбонентаСпецоператораСвязи.Изменение;
			}
			else if(Ссылка == Пролонгация)
			{
				return ТипыЗаявленияАбонентаСпецоператораСвязи.Пролонгация;
			}
			else if(Ссылка == Восстановление)
			{
				return ТипыЗаявленияАбонентаСпецоператораСвязи.Восстановление;
			}
			return ТипыЗаявленияАбонентаСпецоператораСвязи.ПустаяСсылка;
		}
		public static byte[] Ключ(this ТипыЗаявленияАбонентаСпецоператораСвязи Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ТипыЗаявленияАбонентаСпецоператораСвязи Значение)
		{
			switch (Значение)
			{
				case ТипыЗаявленияАбонентаСпецоператораСвязи.Первичное: return Первичное;
				case ТипыЗаявленияАбонентаСпецоператораСвязи.Изменение: return Изменение;
				case ТипыЗаявленияАбонентаСпецоператораСвязи.Пролонгация: return Пролонгация;
				case ТипыЗаявленияАбонентаСпецоператораСвязи.Восстановление: return Восстановление;
			}
			return Guid.Empty;
		}
	}
}