﻿Ext.require(['Данные.Обработки.ОбщиеОбъектыРегламентированнойОтчетности'], function () 
{
	Ext.define('Обработки.ОбщиеОбъектыРегламентированнойОтчетности.ПечатьРегламентированныхОтчетов',
	{
	extend: 'Ext.window.Window',
	id: 'ПечатьРегламентированныхОтчетов',
	style: 'position:absolute;width:740px;height:450px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	resizable: false,
	title: 'Предварительный просмотр',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		ПервоеОткрытие: true,
		items:
		[
		{
			id: 'СписокЛистов',
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:51px;width:198px;height:244px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: '', Граница: 'Левая', Номер: 6, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
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
			Высота:244,
			Ширина:198,
			Верх:51,
			Лево:8,
			height: 244,width: 198,
			columns:
			[
				{
					text:'',
					width:'21',
					dataIndex:'Пометка',
					flex:1,
				},
				{
					text:'Наименование',
					width:'158',
					dataIndex:'Наименование',
					flex:1,
				},
				{
					text:'Табличный документ',
					width:'100',
					dataIndex:'ТабличныйДокумент',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ОбщиеОбъектыРегламентированнойОтчетности/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Пометка',
					},
					{
						name:'Наименование',
					},
					{
						name:'ТабличныйДокумент',
					},
				]
			},
			listeners:
			{
				dblclick:
				{
					element: 'body',
					fn: function ()
					{
						var грид = Ext.getCmp('СписокЛистов');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data.Ссылка;
						var Хранилище = грид.store;
						var стрЗнач = Хранилище.findRecord('Ссылка', ссылка).data;
						Ext.require(['Справочники.ОбщиеОбъектыРегламентированнойОтчетности.ПечатьРегламентированныхОтчетовСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ОбщиеОбъектыРегламентированнойОтчетности.ПечатьРегламентированныхОтчетовСобытия");
							obj.ПередатьСсылку(стрЗнач);
						});
					}
				}
			},
		},
		{
			xtype: 'label',
			id: 'ТекстСтатистики',
			text: 'ТекстСтатистики',
			style: 'position:absolute;left:11px;top:430px;width:417px;height:15px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: 'Форма', Граница: 'Нижняя', Номер: 0, Координата: 0},
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
			Высота:15,
			Ширина:417,
			Верх:430,
			Лево:11,
		},
		{
			xtype: 'label',
			id: 'РамкаГруппы1',
			text: 'Печатаемые листы',
			style: 'position:absolute;left:8px;top:7px;width:198px;height:17px;border-bottom: 2px solid maroon; color: #9F6500; border-width:thin ; border-color: #B3AC86; font-weight: 600;'
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: '', Граница: 'Левая', Номер: 6, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'РамкаГруппы1', Граница: 'Верхняя', Номер: 17, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:17,
			Ширина:198,
			Верх:7,
			Лево:8,
		},
		{
			xtype: 'label',
			id: 'ОпцииПечати',
			text: 'Параметры печати',
			style: 'position:absolute;left:8px;top:301px;width:198px;height:16px;border-bottom: 2px solid maroon; color: #9F6500; border-width:thin ; border-color: #B3AC86; font-weight: 600;'
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: '', Граница: 'Левая', Номер: 6, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 4, Координата: 0},
					Нижняя: { Элемент: 'ОпцииПечати', Граница: 'Верхняя', Номер: 22, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:16,
			Ширина:198,
			Верх:301,
			Лево:8,
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			id: 'КоличествоКопий',
			style: 'position:absolute;left:117px;top:319px;width:40px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'КоличествоКопий', Граница: 'Левая', Номер: 23, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 4, Координата: 0},
					Нижняя: { Элемент: 'КоличествоКопий', Граница: 'Верхняя', Номер: 23, Координата: 0},
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
			Ширина:40,
			Верх:319,
			Лево:117,
			width: 40,
			height: 19,
		},
		{
			xtype: 'label',
			id: 'НадписьКоличествоКопий',
			text: 'Количество копий:',
			style: 'position:absolute;left:14px;top:320px;width:100px;height:18px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'НадписьКоличествоКопий', Граница: 'Левая', Номер: 24, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 4, Координата: 0},
					Нижняя: { Элемент: 'НадписьКоличествоКопий', Граница: 'Верхняя', Номер: 24, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:18,
			Ширина:100,
			Верх:320,
			Лево:14,
		},
		{
			xtype: 'checkbox',
			id: 'РазобратьПоКопиям',
			boxLabel: 'разобрать по копиям',
			style: 'position:absolute;left:14px;top:340px;width:131px;height:15px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'РазобратьПоКопиям', Граница: 'Левая', Номер: 25, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 4, Координата: 0},
					Нижняя: { Элемент: 'РазобратьПоКопиям', Граница: 'Верхняя', Номер: 25, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:15,
			Ширина:131,
			Верх:340,
			Лево:14,
		},
		{
			xtype: 'label',
			id: 'ПараметрыПредПросмотра',
			text: 'Параметры таблицы',
			style: 'position:absolute;left:8px;top:361px;width:197px;height:16px;border-bottom: 2px solid maroon; color: #9F6500; border-width:thin ; border-color: #B3AC86; font-weight: 600;'
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: '', Граница: 'Левая', Номер: 6, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 4, Координата: 0},
					Нижняя: { Элемент: 'ПараметрыПредПросмотра', Граница: 'Верхняя', Номер: 26, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:16,
			Ширина:197,
			Верх:361,
			Лево:8,
		},
		{
			xtype: 'checkbox',
			id: 'ОтображатьСетку',
			boxLabel: 'отображать сетку',
			style: 'position:absolute;left:14px;top:381px;width:111px;height:15px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'ОтображатьСетку', Граница: 'Левая', Номер: 27, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 4, Координата: 0},
					Нижняя: { Элемент: 'ОтображатьСетку', Граница: 'Верхняя', Номер: 27, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:15,
			Ширина:111,
			Верх:381,
			Лево:14,
		},
		{
			xtype: 'checkbox',
			id: 'ОтображатьЗаголовки',
			boxLabel: 'отображать заголовки',
			style: 'position:absolute;left:14px;top:401px;width:135px;height:16px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'ОтображатьЗаголовки', Граница: 'Левая', Номер: 28, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 4, Координата: 0},
					Нижняя: { Элемент: 'ОтображатьЗаголовки', Граница: 'Верхняя', Номер: 28, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:16,
			Ширина:135,
			Верх:401,
			Лево:14,
		},
		{
			xtype: 'toolbar',
			id: КоманднаяПанельСписокЛистов,
			style: 'position:absolute;left:8px;top:25px;width:198px;height:24px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: '', Граница: 'Левая', Номер: 6, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'КоманднаяПанельСписокЛистов', Граница: 'Верхняя', Номер: 31, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:24,
			Ширина:198,
			Верх:25,
			Лево:8,
			width: 198,
			height: 24,
			items:
			[
				{
					id:'УстановитьПометки',
					text:'Установить пометки',
					tooltip:'Установить пометки',
				},
				{
					id:'РаспометитьВсе',
					text:'Снять пометки',
					tooltip:'Снять пометки',
				},
				'-',
				{
					id:'Раскрыть',
					text:'Раскрыть',
					tooltip:'',
				},
				{
					id:'Свернуть',
					text:'Свернуть',
					tooltip:'',
				},
				'-',
				{
					id:'ПереместитьВниз',
					text:'Переместить вниз',
					tooltip:'Переместить вниз',
				},
				{
					id:'ПереместитьВверх',
					text:'Переместить вверх',
					tooltip:'Переместить вверх',
				},
			]
		},
		{
			xtype: 'label',
			id: 'РамкаГруппы2',
			text: 'Содержание',
			style: 'position:absolute;left:212px;top:7px;width:521px;height:17px;border-bottom: 2px solid maroon; color: #9F6500; border-width:thin ; border-color: #B3AC86; font-weight: 600;'
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Правая', Номер: 6, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:17,
			Ширина:521,
			Верх:7,
			Лево:212,
		},
		],
	}],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			id: ОсновныеДействияФормы,
			style: 'position:absolute;left:0px;top:425px;width:740px;height:25px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: 'ОсновныеДействияФормы', Граница: 'Нижняя', Номер: 3, Координата: 0},
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
			Ширина:740,
			Верх:425,
			Лево:0,
			width: 740,
			height: 25,
			dock: 'bottom',
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					id:'АктивизироватьРодительскийОтчет',
					text:'',
					tooltip:'Перейти в родительский отчет',
				},
				'-',
				'-',
				{
					id:'Печать',
					text:'Печать',
					tooltip:'abdab67-5c90-4296-8168-239d22024d1',
					iconCls:'x-PrintImmediately',
				},
				'-',
				{
					id:'Закрыть',
					text:'Закрыть',
					tooltip:'Закрыть',
					iconCls:'x-Close',
					handler: function () {this.up('window').close();},
				},
				'-',
				{
					id:'Действие',
					text:'Справка',
					tooltip:'Открыть справку',
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