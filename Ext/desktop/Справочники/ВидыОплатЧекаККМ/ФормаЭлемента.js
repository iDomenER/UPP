﻿Ext.require(['Данные.Справочники.ВидыОплатЧекаККМ'], function () 
{
	Ext.define('Справочники.ВидыОплатЧекаККМ.ФормаЭлемента',
	{
	extend: 'Ext.window.Window',
	id: 'ФормаЭлемента',
	style: 'position:absolute;width:454px;height:180px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	resizable: false,
	title: 'Вид оплаты чека ККМ',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		ПервоеОткрытие: true,
		items:
		[
		{
			xtype: 'toolbar',
			id: ДействияФормы,
			style: 'position:absolute;left:0px;top:0px;width:454px;height:25px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'ДействияФормы', Граница: 'Верхняя', Номер: 7, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:25,
			Ширина:454,
			Верх:0,
			Лево:0,
			width: 454,
			height: 25,
			items:
			[
			]
		},
		{
			xtype: 'label',
			id: 'НадписьКод',
			text: 'Код:',
			style: 'position:absolute;left:358px;top:33px;width:23px;height:19px;text-align:center;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'НадписьКод', Граница: 'Левая', Номер: 9, Координата: 0},
					Левая: { Элемент: '', Граница: 'Правая', Номер: 12, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'НадписьКод', Граница: 'Верхняя', Номер: 9, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:23,
			Верх:33,
			Лево:358,
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			id: 'Код',
			width: 60,
			height: 19,
			style: 'position:absolute;left:386px;top:33px;width:60px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Код', Граница: 'Левая', Номер: 10, Координата: 0},
					Левая: { Элемент: '', Граница: 'Правая', Номер: 12, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'Код', Граница: 'Верхняя', Номер: 10, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:60,
			Верх:33,
			Лево:386,
		},
		{
			xtype: 'label',
			id: 'НадписьНаименование',
			text: 'Наименование:',
			style: 'position:absolute;left:8px;top:33px;width:134px;height:19px;text-align:left;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'НадписьНаименование', Граница: 'Левая', Номер: 11, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'НадписьНаименование', Граница: 'Верхняя', Номер: 11, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:134,
			Верх:33,
			Лево:8,
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			id: 'Наименование',
			width: 204,
			height: 19,
			style: 'position:absolute;left:148px;top:33px;width:204px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'Наименование', Граница: 'Верхняя', Номер: 12, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:204,
			Верх:33,
			Лево:148,
		},
		{
			xtype: 'label',
			id: 'НадписьТипОплаты',
			text: 'Тип оплаты:',
			style: 'position:absolute;left:8px;top:57px;width:134px;height:19px;text-align:left;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'НадписьТипОплаты', Граница: 'Левая', Номер: 14, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'НадписьТипОплаты', Граница: 'Верхняя', Номер: 14, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:134,
			Верх:57,
			Лево:8,
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			id: 'ТипОплаты',
			name: 'ТипОплаты.Представление',
			width: 298,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:148px;top:57px;width:298px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'ТипОплаты', Граница: 'Верхняя', Номер: 15, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:298,
			Верх:57,
			Лево:148,
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Справочники.ВидыОплатЧекаККМ.ФормаЭлементаСобытия'], function ()
					{
						var объект = Ext.create("Справочники.ВидыОплатЧекаККМ.ФормаЭлементаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Справочники.ВидыОплатЧекаККМ.ФормаЭлементаСобытия'], function ()
					{
						var объект = Ext.create("Справочники.ВидыОплатЧекаККМ.ФормаЭлементаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
		{
			xtype: 'panel',
			id: ПанельБанковскийКредит,
			style: 'position:absolute;left:8px;top:80px;width:438px;height:67px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:67,
			Ширина:438,
			Верх:80,
			Лево:8,
			height: 67,width: 438,
			tabBar:{hidden:true},
			items:
			[
				{
					id: Страница1,
					items:
					[
		{
			xtype: 'label',
			id: 'НадписьБанкКредитор',
			text: 'Банк-кредитор:',
			style: 'position:absolute;left:0px;top:0px;width:134px;height:19px;text-align:left;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'НадписьБанкКредитор', Граница: 'Левая', Номер: 40, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'НадписьБанкКредитор', Граница: 'Верхняя', Номер: 40, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:134,
			Верх:0,
			Лево:0,
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-search-trigger',
			id: 'БанкКредитор',
			name: 'БанкКредитор.Представление',
			width: 298,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:140px;top:0px;width:298px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:298,
			Верх:0,
			Лево:140,
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Справочники.ВидыОплатЧекаККМ.ФормаЭлементаСобытия'], function ()
					{
						var объект = Ext.create("Справочники.ВидыОплатЧекаККМ.ФормаЭлементаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Справочники.ВидыОплатЧекаККМ.ФормаЭлементаСобытия'], function ()
					{
						var объект = Ext.create("Справочники.ВидыОплатЧекаККМ.ФормаЭлементаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
		{
			xtype: 'label',
			id: 'НадписьДоговорВзаиморасчетовБанкаКредитора',
			text: 'Договор взаиморасчетов:',
			style: 'position:absolute;left:0px;top:24px;width:134px;height:19px;text-align:left;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'НадписьДоговорВзаиморасчетовБанкаКредитора', Граница: 'Левая', Номер: 42, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'НадписьДоговорВзаиморасчетовБанкаКредитора', Граница: 'Верхняя', Номер: 42, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:134,
			Верх:24,
			Лево:0,
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-search-trigger',
			id: 'ДоговорВзаиморасчетовБанкаКредитора',
			name: 'ДоговорВзаиморасчетовБанкаКредитора.Представление',
			width: 298,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:140px;top:24px;width:298px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:298,
			Верх:24,
			Лево:140,
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Справочники.ВидыОплатЧекаККМ.ФормаЭлементаСобытия'], function ()
					{
						var объект = Ext.create("Справочники.ВидыОплатЧекаККМ.ФормаЭлементаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Справочники.ВидыОплатЧекаККМ.ФормаЭлементаСобытия'], function ()
					{
						var объект = Ext.create("Справочники.ВидыОплатЧекаККМ.ФормаЭлементаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
		{
			xtype: 'label',
			id: 'НадписьПроцентБанковскойКомиссии',
			text: '% банковской комиссии:',
			style: 'position:absolute;left:0px;top:48px;width:134px;height:19px;text-align:left;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'НадписьПроцентБанковскойКомиссии', Граница: 'Левая', Номер: 44, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'НадписьПроцентБанковскойКомиссии', Граница: 'Верхняя', Номер: 44, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:134,
			Верх:48,
			Лево:0,
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			id: 'ПроцентБанковскойКомиссии',
			style: 'position:absolute;left:140px;top:48px;width:92px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:92,
			Верх:48,
			Лево:140,
			width: 92,
			height: 19,
		},
					]
				},
			]
		},
		],
	}],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			id: ОсновныеДействияФормы,
			style: 'position:absolute;left:0px;top:155px;width:454px;height:25px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: 'ОсновныеДействияФормы', Граница: 'Нижняя', Номер: 8, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Нижняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:25,
			Ширина:454,
			Верх:155,
			Лево:0,
			width: 454,
			height: 25,
			dock: 'bottom',
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					id:'Действие',
					text:'OK',
					tooltip:'Записать объект и закрыть форму',
					iconCls:'x-WriteAndClose',
				},
				'-',
				{
					id:'Действие1',
					text:'Записать',
					tooltip:'Записать объект',
					iconCls:'x-SaveFile',
				},
				'-',
				{
					id:'Действие2',
					text:'Закрыть',
					tooltip:'Закрыть',
					iconCls:'x-Close',
					handler: function () {this.up('window').close();},
				},
			]
		},
	]
	});
	listeners:
	{
		resize:
		{
			fn: function (win, width, height, opt)
			{
				var форма = win.down('form');
				if (!форма.ПервоеОткрытие)
				{
					форма.items.each(function (item)
					{
					ПривязкаГраниц(item, item.ПозицияЭлемента);
					if (item.Групповой)
					{
						var элемент = Ext.getCmp(item.id).items.items[0].items.items;
						for (i = 0; i <= элемент.length -1; i += 1) 
						{
							var текЭлемент = элемент[i];
							ПривязкаГраниц(текЭлемент, текЭлемент.ПозицияЭлемента);
						}
					}
					});
				}
			}
		}
	}
});