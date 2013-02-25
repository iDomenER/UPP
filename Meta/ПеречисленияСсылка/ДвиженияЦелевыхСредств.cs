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
	public enum ДвиженияЦелевыхСредств
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"a4a1b08e-046c-416d-98e6-4fe4061e6de8\", \"Представление\":\"ВступительныеВзносы\"}")]
		ВступительныеВзносы = 0,//Вступительные взносы
		[EnumMember(Value = "{\"Ссылка\":\"44e35671-defe-45e8-8f45-1722ba1925ef\", \"Представление\":\"ЧленскиеВзносы\"}")]
		ЧленскиеВзносы = 1,//Членские взносы
		[EnumMember(Value = "{\"Ссылка\":\"ea496f2d-066b-4098-baa3-d5d7d3692055\", \"Представление\":\"ДобровольныеВзносы\"}")]
		ДобровольныеВзносы = 2,//Добровольные взносы
		[EnumMember(Value = "{\"Ссылка\":\"ac10619d-f5fa-4f82-a99f-59fd50716dba\", \"Представление\":\"ДоходыОтПредпринимательскойДеятельностиОрганизации\"}")]
		ДоходыОтПредпринимательскойДеятельностиОрганизации = 3,//Доходы от предпринимательской деятельности организации
		[EnumMember(Value = "{\"Ссылка\":\"2986c081-1d4f-4314-8df6-dc0a6f219db9\", \"Представление\":\"ПрочиеПоступления\"}")]
		ПрочиеПоступления = 4,//Прочие поступления
		[EnumMember(Value = "{\"Ссылка\":\"0a5e9297-da09-45e4-992c-a049fb79bee5\", \"Представление\":\"ОказаниеСоциальнойИБлаготворительнойПомощи\"}")]
		ОказаниеСоциальнойИБлаготворительнойПомощи = 5,//Оказание социальной и благотворительной помощи
		[EnumMember(Value = "{\"Ссылка\":\"1b1aae29-3543-470c-8174-a7223fbc739d\", \"Представление\":\"ПроведениеКонференцийСеминаров\"}")]
		ПроведениеКонференцийСеминаров = 6,//Проведение конференций семинаров и т.п.
		[EnumMember(Value = "{\"Ссылка\":\"4434e334-e682-43e9-ace7-21f27a566562\", \"Представление\":\"ПроведениеИныхЦелевыхМероприятий\"}")]
		ПроведениеИныхЦелевыхМероприятий = 7,//Проведение иных целевых мероприятий
		[EnumMember(Value = "{\"Ссылка\":\"54f5bc93-efb3-488c-9a9d-c921fbe39249\", \"Представление\":\"СодержаниеАппаратаУправления\"}")]
		СодержаниеАппаратаУправления = 8,//Содержание аппарата управления
		[EnumMember(Value = "{\"Ссылка\":\"a77900b5-0028-412d-ab89-6fd9f30fc4c4\", \"Представление\":\"ПриобретениеОсновныхСредствИнвентаряИИногоИмущества\"}")]
		ПриобретениеОсновныхСредствИнвентаряИИногоИмущества = 9,//Приобретение основных средств, инвентаря и иного имущества
		[EnumMember(Value = "{\"Ссылка\":\"88976729-2972-4f0a-8d21-3039557948db\", \"Представление\":\"РасходыСвязанныеСПредпринимательскойДеятельностью\"}")]
		РасходыСвязанныеСПредпринимательскойДеятельностью = 10,//Расходы связанные с предпринимательской деятельностью
		[EnumMember(Value = "{\"Ссылка\":\"ac09ee6f-b946-4fd3-a685-b0167d805b4f\", \"Представление\":\"ПрочиеРасходы\"}")]
		ПрочиеРасходы = 11,//Прочие расходы
	}
	public static partial class ДвиженияЦелевыхСредств_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ВступительныеВзносы = new Guid("e44fe698-1e06-e86d-416d-046ca4a1b08e");//Вступительные взносы
		public static readonly Guid ЧленскиеВзносы = new Guid("2217458f-19ba-ef25-45e8-defe44e35671");//Членские взносы
		public static readonly Guid ДобровольныеВзносы = new Guid("d7d5a3ba-69d3-5520-4098-066bea496f2d");//Добровольные взносы
		public static readonly Guid ДоходыОтПредпринимательскойДеятельностиОрганизации = new Guid("fd599fa9-7150-ba6d-4f82-f5faac10619d");//Доходы от предпринимательской деятельности организации
		public static readonly Guid ПрочиеПоступления = new Guid("0adcf68d-216f-b99d-4314-1d4f2986c081");//Прочие поступления
		public static readonly Guid ОказаниеСоциальнойИБлаготворительнойПомощи = new Guid("49a02c99-79fb-e5be-45e4-da090a5e9297");//Оказание социальной и благотворительной помощи
		public static readonly Guid ПроведениеКонференцийСеминаров = new Guid("22a77481-bc3f-9d73-470c-35431b1aae29");//Проведение конференций семинаров и т.п.
		public static readonly Guid ПроведениеИныхЦелевыхМероприятий = new Guid("f221e7ac-567a-6265-43e9-e6824434e334");//Проведение иных целевых мероприятий
		public static readonly Guid СодержаниеАппаратаУправления = new Guid("21c99d9a-e3fb-4992-488c-efb354f5bc93");//Содержание аппарата управления
		public static readonly Guid ПриобретениеОсновныхСредствИнвентаряИИногоИмущества = new Guid("d96f89ab-0ff3-c4c4-412d-0028a77900b5");//Приобретение основных средств, инвентаря и иного имущества
		public static readonly Guid РасходыСвязанныеСПредпринимательскойДеятельностью = new Guid("3930218d-7955-db48-4f0a-297288976729");//Расходы связанные с предпринимательской деятельностью
		public static readonly Guid ПрочиеРасходы = new Guid("16b085a6-807d-4f5b-4fd3-b946ac09ee6f");//Прочие расходы
		public static ДвиженияЦелевыхСредств Получить(this ДвиженияЦелевыхСредств Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ДвиженияЦелевыхСредств Получить(this ДвиженияЦелевыхСредств Значение, Guid Ссылка)
		{
			if(Ссылка == ВступительныеВзносы)
			{
				return ДвиженияЦелевыхСредств.ВступительныеВзносы;
			}
			else if(Ссылка == ЧленскиеВзносы)
			{
				return ДвиженияЦелевыхСредств.ЧленскиеВзносы;
			}
			else if(Ссылка == ДобровольныеВзносы)
			{
				return ДвиженияЦелевыхСредств.ДобровольныеВзносы;
			}
			else if(Ссылка == ДоходыОтПредпринимательскойДеятельностиОрганизации)
			{
				return ДвиженияЦелевыхСредств.ДоходыОтПредпринимательскойДеятельностиОрганизации;
			}
			else if(Ссылка == ПрочиеПоступления)
			{
				return ДвиженияЦелевыхСредств.ПрочиеПоступления;
			}
			else if(Ссылка == ОказаниеСоциальнойИБлаготворительнойПомощи)
			{
				return ДвиженияЦелевыхСредств.ОказаниеСоциальнойИБлаготворительнойПомощи;
			}
			else if(Ссылка == ПроведениеКонференцийСеминаров)
			{
				return ДвиженияЦелевыхСредств.ПроведениеКонференцийСеминаров;
			}
			else if(Ссылка == ПроведениеИныхЦелевыхМероприятий)
			{
				return ДвиженияЦелевыхСредств.ПроведениеИныхЦелевыхМероприятий;
			}
			else if(Ссылка == СодержаниеАппаратаУправления)
			{
				return ДвиженияЦелевыхСредств.СодержаниеАппаратаУправления;
			}
			else if(Ссылка == ПриобретениеОсновныхСредствИнвентаряИИногоИмущества)
			{
				return ДвиженияЦелевыхСредств.ПриобретениеОсновныхСредствИнвентаряИИногоИмущества;
			}
			else if(Ссылка == РасходыСвязанныеСПредпринимательскойДеятельностью)
			{
				return ДвиженияЦелевыхСредств.РасходыСвязанныеСПредпринимательскойДеятельностью;
			}
			else if(Ссылка == ПрочиеРасходы)
			{
				return ДвиженияЦелевыхСредств.ПрочиеРасходы;
			}
			return ДвиженияЦелевыхСредств.ПустаяСсылка;
		}
		public static byte[] Ключ(this ДвиженияЦелевыхСредств Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ДвиженияЦелевыхСредств Значение)
		{
			switch (Значение)
			{
				case ДвиженияЦелевыхСредств.ВступительныеВзносы: return ВступительныеВзносы;
				case ДвиженияЦелевыхСредств.ЧленскиеВзносы: return ЧленскиеВзносы;
				case ДвиженияЦелевыхСредств.ДобровольныеВзносы: return ДобровольныеВзносы;
				case ДвиженияЦелевыхСредств.ДоходыОтПредпринимательскойДеятельностиОрганизации: return ДоходыОтПредпринимательскойДеятельностиОрганизации;
				case ДвиженияЦелевыхСредств.ПрочиеПоступления: return ПрочиеПоступления;
				case ДвиженияЦелевыхСредств.ОказаниеСоциальнойИБлаготворительнойПомощи: return ОказаниеСоциальнойИБлаготворительнойПомощи;
				case ДвиженияЦелевыхСредств.ПроведениеКонференцийСеминаров: return ПроведениеКонференцийСеминаров;
				case ДвиженияЦелевыхСредств.ПроведениеИныхЦелевыхМероприятий: return ПроведениеИныхЦелевыхМероприятий;
				case ДвиженияЦелевыхСредств.СодержаниеАппаратаУправления: return СодержаниеАппаратаУправления;
				case ДвиженияЦелевыхСредств.ПриобретениеОсновныхСредствИнвентаряИИногоИмущества: return ПриобретениеОсновныхСредствИнвентаряИИногоИмущества;
				case ДвиженияЦелевыхСредств.РасходыСвязанныеСПредпринимательскойДеятельностью: return РасходыСвязанныеСПредпринимательскойДеятельностью;
				case ДвиженияЦелевыхСредств.ПрочиеРасходы: return ПрочиеРасходы;
			}
			return Guid.Empty;
		}
	}
}