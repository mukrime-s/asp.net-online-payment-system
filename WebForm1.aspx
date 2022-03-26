<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="hw1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 34px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div style="height: 400px; width:800px; margin-left: 100px; margin-top:100px;" id="myDiv" runat="server">
                
                <br />

                <asp:Image ID="Image1" runat="server" />

                <br />
                <table>
                    <tr>

                        <td style ="height: 45px; width:70px;"><asp:Image ID="Mastercard" runat="server" src="images/mastercard.PNG" Height="45px" Width="70px"/></td>
                        <td style ="height: 45px; width:70px;"><asp:Image ID="Visa" runat="server" src="images/visa.PNG" Height="45px" Width="70px"/></td>
                        <td style ="height: 45px; width:70px;"><asp:Image ID="Amex" runat="server" src="images/amex.PNG" Height="45px" Width="70px"/></td>
                        <td style ="height: 45px; width:70px;"><asp:Image ID="BCGlobal" runat="server" src="images/bccard.jpeg" Height="45px" Width="70px"/></td>
                        <td style ="height: 45px; width:70px;"><asp:Image ID="Diners" runat="server" src="images/diners.PNG" Height="45px" Width="70px"/></td>
                        <td style ="height: 45px; width:70px;"><asp:Image ID="Carte" runat="server" src="images/carte.jpeg" Height="45px" Width="70px"/></td>
                        <td style ="height: 45px; width:70px;"><asp:Image ID="Discover" runat="server" src="images/discover.PNG" Height="45px" Width="70px"/></td>
                        <td style ="height: 45px; width:70px;"><asp:Image ID="Maestro" runat="server" src="images/maestro.jpeg" Height="45px" Width="70px"/></td>
                    </tr>
                    </table>
                <table>
                    <tr>
                        <td>
                            Card Number
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server"  OnTextChanged="TextBox1_TextChanged" AutoPostBack="True"  Width="416px" TextMode="Number"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Invalid Card Number" ValidationExpression="^(?:4[0-9]{12}(?:[0-9]{3})?|[25][1-7][0-9]{14}|6(?:011|5[0-9][0-9])[0-9]{12}|3[47][0-9]{13}|3(?:0[0-5]|[68][0-9])[0-9]{11}|(?:2131|1800|35\d{3})\d{11})$"></asp:RegularExpressionValidator>
                            <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="Card Number is empty"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    
                    <tr>
                        <td class="auto-style1">
                            
                            EXP.
                            
                            DATE
                            </td>
                        <td class="auto-style1">
                            <asp:TextBox ID="TextBox3" runat="server" Width="61px" TextMode="Number">MM</asp:TextBox>  &nbsp;/  
                            <asp:TextBox ID="TextBox4" runat="server" Width="69px" TextMode="Number">202Y</asp:TextBox> 
                            <asp:Label ID="Label3" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            CVV
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server" TextMode="Number"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Invalid CCV" 
                                    ControlToValidate="TextBox2" ValidationExpression="^[0-9]{3,4}$" Display="Dynamic"></asp:RegularExpressionValidator>
                            <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="CVV is empty"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr >
                        <td >
                            &nbsp;</td>
                       <td>
                            <asp:Button ID="Button1" runat="server" Text="Check" OnClick="Button1_Click"  />
                         <asp:Label ID="Label1" runat="server" ></asp:Label>
                       </td>
                    </tr>
                </table>
            </div>
        </div>
    </form>
</body>
</html>
