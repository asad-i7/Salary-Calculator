<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="SalaryCalculator._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>UK Tax Calculator</title>

    <!-- CSS -->
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="StyleSheet.css" rel="stylesheet" />

    <!-- Custom Fonts -->
    <link href="vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link href='https://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800' rel='stylesheet' type='text/css' />
    <link href='https://fonts.googleapis.com/css?family=Merriweather:400,300,300italic,400italic,700,700italic,900,900italic' rel='stylesheet' type='text/css'>
    <link href='http://fonts.googleapis.com/css?family=Wellfleet' rel='stylesheet' type='text/css' />
    <link href='http://fonts.googleapis.com/css?family=Wellfleet' rel='stylesheet' type='text/css' />
    <link href='http://fonts.googleapis.com/css?family=Arvo:400,700,400italic,700italic' rel='stylesheet' type='text/css' />
    <link href='http://fonts.googleapis.com/css?family=Oswald' rel='stylesheet' type='text/css' />
    <link href='http://fonts.googleapis.com/css?family=Goudy+Bookletter+1911' rel='stylesheet' type='text/css' />

</head>
<body>

    <section id="main">

        <h1 class="header">Income Tax Calculator </h1>

        <div id="text">
            <h2>A Take-Home Salary Calculator</h2>

            <p>This is a take-home wage calculator that allows you to input your yearly income and view how much tax and national insurance is deducted from your gross pay.*</p>

            <p>
                <br />
                <b>The Tax Codes Available Are: </b>
            </p>

            <table>
                <tr>
                    <td>
                        <b>Tax Code</b>
                    </td>
                    <td>
                        <b>Description</b>
                    </td>
                </tr>

                <tr>
                    <td>
                        <b>1100L</b>
                    </td>
                    <td>The default tax code. For most people with one job and no untaxed income
                    </td>
                </tr>

                <tr>
                    <td>
                        <b>BR</b>
                    </td>
                    <td>For people who have a second job and are taxed at the Basic Rate
                    </td>
                </tr>

                <tr>
                    <td>
                        <b>D0</b>
                    </td>
                    <td>For  people who have a second job and are taxed at the Higher Rate
                    </td>
                </tr>

                <tr>
                    <td>
                        <b>D1</b>
                    </td>
                    <td>For people who have a second job and are taxed at the Additional Rate
                    </td>

                </tr>

                <tr>
                    <td>
                        <b>NT</b>
                    </td>
                    <td>For people who have no tax deducted
                    </td>
                </tr>

             </table>

            <p>*Daily Figure based on Full Time Hours.</p>

        </div>

        <div id="calculator">

            <form id="form1" runat="server" width="80%">

                <table class="table">

                    <tr>
                        <td>Annual Salary:
                        </td>
                        <td id="poundsign">
                            <% =this.poundSign%>
                            <asp:TextBox runat="server" ID="wageperyear" TextMode="Number" Text="0" CssClass="enter">  </asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td>Tax Code:
                        </td>
                        <td>
                            <asp:DropDownList runat="server" ID="taxcodes" CssClass="enter2">
                                <asp:ListItem Value="1100L"> </asp:ListItem>
                                <asp:ListItem Value="BR"> </asp:ListItem>
                                <asp:ListItem Value="D0"> </asp:ListItem>
                                <asp:ListItem Value="D1">  </asp:ListItem>
                                <asp:ListItem Value="NT">  </asp:ListItem>

                            </asp:DropDownList>
                        </td>
                    </tr>

                    <tr>
                        <td></td>

                        <td>
                            <asp:Button runat="server" Text="Calculate" OnClick="CalculateButton" CssClass="button" />
                        </td>

                    </tr>

                </table>

                <table class="table">

                    <tr>
                        <td></td>
                        <td>Yearly:
                        </td>
                        <td>Monthly:
                        </td>
                        <td>Weekly:
                        </td>
                        <td>Daily:
                        </td>
                    </tr>

                    <tr>
                        <td>Salary:
                        </td>
                        <td>
                            <% =this.poundSign + this.yearlyGross%>
                        </td>
                        <td>
                            <% =this.poundSign + this.monthlyGross%>
                        </td>
                        <td>
                            <% =this.poundSign + this.weeklyGross%>
                        </td>
                        <td>
                            <% =this.poundSign + this.dailyGross%>
                        </td>
                    </tr>

                    <tr>
                        <td>Tax Deducted:
                        </td>
                        <td>
                            <% =this.poundSign +  this.yearlyTaxDeducted%>
                        </td>
                        <td>
                            <% =this.poundSign +  this.monthlyTaxDeducted%>
                        </td>

                        <td>
                            <% =this.poundSign +  this.weeklyTaxDeducted%>
                        </td>

                        <td>
                            <% =this.poundSign +  this.dailyTaxDeducted%>
                        </td>
                    </tr>

                    <tr>
                        <td>NI Deducted:
                        </td>
                        <td>
                            <% =this.poundSign + this.yearlyNationalInsurance%>
                        </td>
                        <td>
                            <% =this.poundSign +  this.monthlyNationalInsurance%>
                        </td>

                        <td>
                            <% =this.poundSign + this.weeklyNationalInsurance%>
                        </td>
                        <td>
                            <% =this.poundSign + this.dailyNationalInsurance%>
                        </td>
                    </tr>

                    <tr>
                        <td>Total Deducted:
                        </td>
                        <td>
                            <% =this.poundSign + this.yearlyTotalTax%>
                        </td>
                        <td>
                            <% =this.poundSign + this.monthlyTotalTax%>
                        </td>
                        <td>
                            <% =this.poundSign + this.weeklyTotalTax%>
                        </td>
                        <td>
                            <% =this.poundSign + this.dailyTotalTax%>
                        </td>
                    </tr>

                    <tr>
                        <td>Take-home Salary:
                        </td>

                        <td>
                            <% =this.poundSign + this.yearlyNet%>
                        </td>
                        <td>
                            <% =this.poundSign + this.monthlyNet%>
                        </td>
                        <td>
                            <% =this.poundSign + this.weeklyNet%>
                        </td>
                        <td>
                            <% =this.poundSign + this.dailyNet%>
                        </td>
                    </tr>

                </table>
            </form>
        </div>
    </section>

</body>
</html>
