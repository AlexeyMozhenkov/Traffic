<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WaybillsPrintPage.aspx.cs" Inherits="Traffic.Web_Forms.WaybillsPrintPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        table{border-collapse:collapse;
            margin-right: 0px;
        }
        td,tr{border:solid 1px #000;}
        .auto-style1 {
            border-style:hidden;
            width: 80px;
            align-self:center;
            }
        .auto-style2 {
            width: 130px;
        }
        .auto-style3 {
            width: 80px;
        }
        .auto-style4 {
            width: 99px;
        }
        .auto-style5 {
            width: 63px;
        }
        </style>
</head>
<body>
    <script type="text/javascript" ><!--
    function hideContainer() {
        document.getElementById("notprint").style.display = "none";
    }
    function showContainer() {
        document.getElementById("notprint").style.display = "";
    }
</script>


    <form id="form1" runat="server">
        <div style="display: table; margin: 0px auto;">
            	<span style="text-align:center; font-weight:bold;">Путевой лист № <asp:textbox cssclass="auto-style1" runat="server" name="waybillNumber" style="width:70px;" /></span>
            	<span style="margin-left:250px;"><asp:textbox cssclass="auto-style2" runat="server" type="date" name="waybillDate" placeholder="ГГГГ-ММ-ДД" style="width:130px;" /></span>
            </div>
	<div style="width:40%; float:left; margin-top:30px;">
            	<br />
<span style="display:block; text-align:center;"></span>                <hr/>
                <span style="text-align:center; width:100%; display:block; font-size:11px;">наименование перевозчика (штамп)</span>
                
                <table class="show" style="margin-top:30px; border:black 1px solid;">
                	<tr class="header">
                    	<td colspan="3">Автомобиль, прицеп, полуприцеп</td>
                    </tr>
                    <tr class="header">
                    	<td>Марка автомобиля, прицепа, полуприцепа | Регистрационный знак</td>
                        <td>Гаражный номер</td>
                    </tr>
                    <tr>
                   		<td>
                            <select name="registrationNumberTransport">
                                <option value="not">Не выбрано</option>
                                                            </select>
                        </td>
                        <td>
                            
                        </td>
                    </tr>
                    <tr>
                   		<td>
                            <select name="registrationNumberTrailer">
                                <option value="not">Не выбрано</option>
                                                            </select>
                        </td>
                        <td>
                        </td>
                    </tr>
                </table>
                <table class="show" style="margin-top:1px;">
                    <tr class="header">
                    	<td colspan="4">Водитель</td>
                    </tr>
                    <tr class="header">
                    	<td>Фамилия, инициалы | табельный номер, класс</td>
                        <td>Номер водительского удостоверения</td>
                        <td>Водитель по состоянию здоровья  допущен<br/>Подпись (штамп)</td>
                    </tr>
                    <tr>
                        <td width="50%">
                            <select name="registrationNumberEmployee">
                                <option value="not">Не выбрано</option>
                                                            </select>
                        </td>
                        <td>&nbsp;
                            
                        </td>
                        <td></td>
                    </tr>
                </table>
            </div>
            <div style="width:59%; float:right; ">
            	<table class="show" width="100%">
                	<tr class="header"> 
                    	<td colspan="7">Работа водителя и автомобиля</td>
                    </tr>
                    <tr class="header">
                    	<td rowspan="2" class="auto-style3">Операция</td>
                        <td rowspan="2">Показания спидометра</td>
                        <td colspan="2">Дата (год-месяц-число), время (ч, мин)</td>
                        <td rowspan="2" class="auto-style4">Нулевой пробег, км</td>
                        <td colspan="2">Время работы, ч</td>
                    </tr>
                    <tr class="header">
                    	<td class="auto-style3">по графику</td>
                        <td>фактически</td>
                        <td class="auto-style2">двигателя</td>
                        <td>спецобору-<br>дования</td>
                    </tr>
                    <tr>
                    	<td class="auto-style3">Выезд на линию</td>
                        <td><asp:textbox runat="server" cssclass="auto-style1" type="number" name="speedometerON" Height="18px" /></td>
                        <td class="auto-style3"><asp:textbox cssclass="auto-style2" runat="server" type="date" placeholder="ГГГГ-ММ-ДД" name="dateGrafficON" /><br>
                        	<asp:textbox cssclass="auto-style1" runat="server" type="time" placeholder="ЧЧ:ММ" name="timeGrafficON" /></td>
                        <td><asp:textbox cssclass="auto-style2" runat="server" type="date" placeholder="ГГГГ-ММ-ДД" name="dateFactON" /><br>
                        	<asp:textbox cssclass="auto-style1" runat="server" type="time" placeholder="ЧЧ:ММ" name="timeFactON" /></td>
                        <td >
                        </td>
                        <td class="auto-style2">
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                    	<td class="auto-style3">Возвращение с линии</td>
                        <td ><asp:textbox cssclass="auto-style1" runat="server" type="number" name="speedometerOFF" /></td>
                        <td class="auto-style3"><asp:textbox cssclass="auto-style2" runat="server" type="date" placeholder="ГГГГ-ММ-ДД" name="dateGrafficOFF" /><br>
                        	<asp:textbox cssclass="auto-style1" runat="server" type="time" placeholder="ЧЧ:ММ" name="timeGrafficOFF" /></td>
                        <td><asp:textbox cssclass="auto-style2" runat="server" type="date" placeholder="ГГГГ-ММ-ДД" name="dateFactOFF" /><br>
                        	<asp:textbox cssclass="auto-style1" runat="server" type="time" placeholder="ЧЧ:ММ" name="timeFactOFF" /></td>
                        <td><asp:textbox cssclass="auto-style1" runat="server" type="number" name="zeroMileageOFF" Width="47px"/></td>
						<td><asp:textbox cssclass="auto-style1" runat="server" type="number" name="workTimeEngineOFF" Width="50px"/></td>
                        <td><asp:textbox cssclass="auto-style1" runat="server" type="number" name="workTimeEquipmentOFF" Width="50px"/></td>
                    </tr>
                </table>
                <table class="show" style="margin-top:20px; width: 100%;">
                	<tr class="header">
                    	<td colspan="5">Движение топливно-смазочных материалов (ТСМ)</td>
                    </tr>
                    <tr class="header">
                    	<td colspan="2">Заправка ТСМ</td>
                        <td colspan="3">Остаток ТСМ, л</td>
                    </tr>
                    <tr class="header">
                    	<td>дата</td>
                        <td class="auto-style3">марка ТСМ</td>
                        <td class="auto-style3">количество, л</td>
                        <td class="auto-style3">при выезде</td>
                        <td>при возвращении</td>
                    </tr>
                    <tr>
                    	<td><asp:textbox cssclass="auto-style2" runat="server" type="date" name="fuelDate1" placeholder="ГГГГ-ММ-ДД"/></td>
                        <td"><asp:textbox cssclass="auto-style1" runat="server" type="text" name="fuelMark1"/></td>
                        <td><asp:textbox cssclass="auto-style1" runat="server" type="number" name="fuelKol1"/></td>
                        <td rowspan="2"><asp:textbox cssclass="auto-style1" runat="server" type="number" name="fuelKolLeaving"/></td>
                        <td rowspan="2"><asp:textbox cssclass="auto-style1" runat="server" type="number" name="fuelKolArriving"/></td>
                        <td rowspan="2"><asp:textbox cssclass="auto-style1" runat="server" type="number" name="fuelKol2"/></td>
                    </tr>
                    <tr>
                    	<td><asp:textbox cssclass="auto-style2" runat="server" type="date" name="fuelDate2" placeholder="ГГГГ-ММ-ДД"/></td>
                        <td><asp:textbox cssclass="auto-style1" runat="server" type="text" name="fuelMark2"/></td>
                        
                    </tr>
                    <tr>
                    	<td><asp:textbox cssclass="auto-style2" runat="server" type="date" name="fuelDate3" placeholder="ГГГГ-ММ-ДД"/></td>
                        <td><asp:textbox cssclass="auto-style1" runat="server" type="text" name="fuelMark3"/></td>
                        <td><asp:textbox cssclass="auto-style1" runat="server" type="number" name="fuelKol3"/></td>
                        <td class="header" colspan="2">Подписи (штамп)</td>
                    </tr>
                    <tr>
                    	<td><asp:textbox cssclass="auto-style2" runat="server" type="date" name="fuelDate4" placeholder="ГГГГ-ММ-ДД"/></td>
                        <td class="auto-style3"><asp:textbox cssclass="auto-style1" runat="server" type="text" name="fuelMark4"/></td>
                        <td class="auto-style3"><asp:textbox cssclass="auto-style1" runat="server" type="number" name="fuelKol4"/></td>
                        <td class="auto-style3">механик</td>
                        <td class="header">механик</td>
                    </tr>
                    <tr>
                    	<td><asp:textbox cssclass="auto-style2" runat="server" type="date" name="fuelDate5" placeholder="ГГГГ-ММ-ДД"/></td>
                        <td><asp:textbox cssclass="auto-style1" runat="server" type="text" name="fuelMark5"/></td>
                        <td><asp:textbox cssclass="auto-style1" runat="server" type="number" name="fuelKol5"/></td>
                        <td rowspan="2"></td>
                        <td rowspan="2"></td>
                    </tr>
                    <tr>
                    	<td><asp:textbox cssclass="auto-style2" runat="server" type="date" name="fuelDate6" placeholder="ГГГГ-ММ-ДД"/></td>
                        <td><asp:textbox cssclass="auto-style1" runat="server" type="text" name="fuelMark6"/></td>
                        <td><asp:textbox cssclass="auto-style1" runat="server" type="number" name="fuelKol6"/></td>
                    </tr>
                </table>
                <span style="display:block; text-align:center; margin-top:5px;">Утверждаю,
                <select name="approver">
                	<option value="not">Не выбрано</option>
                                    </select> ________________________</span>
            </div>
            <div style="clear:both;"></div>
            <div>
            	<table class="show" width="100%" style="margin-top:5px;" id="p_scents">
                	<tr class="header">
                    	<td colspan="9">Задание водителю (цель: доставка груза получателю) согласно приказу №
            	<span style="text-align:center; font-weight:bold;"><asp:textbox cssclass="auto-style1" runat="server" type="text" name="orderNumber" style="width:70px;"/></span> от 
            	<span style="margin-left:10px;"><asp:textbox cssclass="auto-style2" runat="server" type="date" name="waybillDate11" placeholder="ГГГГ-ММ-ДД"/></span>
                        </td>
                    </tr>
                    <tr class="header">
                    	<td rowspan="2" class="auto-style5">Заказчик</td>
                        <td colspan="2">Дата, время</td>
                        <td rowspan="2">Пункт отправления(адрес места погрузки)</td>
                        <td rowspan="2">Пункт назначения(адрес места разгрузки)</td>
                        <td rowspan="2">Расстояние, км</td>
                        <td rowspan="2">Наименование груза</td>
                        <td rowspan="2">Вес груза, т</td>
                        <td rowspan="2">Количество поездок с грузом, ч</td>
                     </tr>
                     <tr class="header">
                        <td>прибытия</td>
                        <td>убытия</td>
                    </tr>
                    <tr>
                    	 <td class="auto-style5">
                            <select name="client1">
                                <option value="not">Не выбрано</option>
                                <option value="15">Белорусско-Российский университет</option><option value="16">Тестовая организация 2</option>                            </select>
                        </td>
                        <td>
                        	<asp:textbox cssclass="auto-style2" runat="server" type="date" name="dateArrive1" placeholder="ГГГГ-ММ-ДД" /><br />
                            <asp:textbox cssclass="auto-style1" runat="server" type="time" name="timeArrive1" placeholder="ЧЧ:ММ" />
                        </td>
                        <td>
                        	<asp:textbox cssclass="auto-style2" runat="server" type="date" name="dateLeaving1" placeholder="ГГГГ-ММ-ДД" /><br />
                            <asp:textbox cssclass="auto-style1" runat="server" type="time" name="timeLeaving1" placeholder="ЧЧ:ММ" />
                        </td>
                        <td>
                        	<asp:textbox cssclass="auto-style1" runat="server" type="text" name="punctLeaving1" />
                        </td>
                         <td>
                        	<asp:textbox cssclass="auto-style1" runat="server" type="text" name="punctArrive1" />
                        </td>
                        <td>
                        	<asp:textbox cssclass="auto-style1" runat="server" type="number" name="routeMileage1" />
                        </td>
                        <td>
                        	<asp:textbox cssclass="auto-style1" runat="server" type="text" name="load1" />
                        </td>
                        <td>
                        	<asp:textbox cssclass="auto-style1" runat="server" type="number" name="weight1" />
                        </td>
                        <td>
                        	<asp:textbox cssclass="auto-style1" runat="server" type="number" name="loadTime1" />
                        </td>
                    </tr>
                  </table>
             </div>
        <div id="notprint">
        <asp:Button ID="Print" runat="server" OnClientClick="javascript:hideContainer();window.print();" Text="Print" Width="120px" />
        </div>
</form>
</body>
</html>
