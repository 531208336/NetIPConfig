<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ZebraPuma.Web.NetIPConfig.index" %>

<head>
    <title>Net IP Config</title>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <div class="container">
        <form class="form-horizontal col-md-6 col-md-offset-3" runat="server">
            <div class="panel panel-default">
                <div class="panel-heading"style="text-align:center">
                    <h1>
                        <asp:label runat="server" text="Label" id="Title"></asp:label>
                    </h1>
                </div>
            </div>
            <div class="panel panel-default">
                <div class="panel-heading">Operating System</div>
                <div class="panel-body">
                    <div class="form-group">
                        <div class="col-md-4 col-xs-4">
                            <img src="images/MacOSX.png" class="img-responsive center-block" />
                        </div>
                        <div class="col-md-4 col-xs-4">
                            <img src="images/Linux.png" class="img-responsive center-block" />
                        </div>
                        <div class="col-md-4 col-xs-4">
                            <img src="images/Windows.png" class="img-responsive center-block" />
                        </div>
                    </div>
                </div>
            </div>
            <div class="panel panel-default">
                <div class="panel-heading">Configuration IP</div>
                <div class="panel-body">
                    <div class="form-group">
                        <label for="ip_a" class="control-label col-md-2 col-md-offset-1 col-xs-2 col-xs-offset-1">IP :</label>
                        <div class="input-group col-md-8 col-xs-8">
                            <input type="text" class="form-control" id="ip_a" runat="server">
                            <div class="input-group-addon">.</div>
                            <input type="text" class="form-control" id="ip_b" runat="server">
                            <div class="input-group-addon">.</div>
                            <input type="text" class="form-control" id="ip_c" runat="server">
                            <div class="input-group-addon">.</div>
                            <input type="text" class="form-control" id="ip_d" runat="server">
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="net_a" class="control-label col-md-2 col-md-offset-1 col-xs-2 col-xs-offset-1">Net :</label>
                        <div class="input-group col-md-8 col-xs-8">
                            <input type="text" class="form-control" id="net_a" runat="server">
                            <div class="input-group-addon">.</div>
                            <input type="text" class="form-control" id="net_b" runat="server">
                            <div class="input-group-addon">.</div>
                            <input type="text" class="form-control" id="net_c" runat="server">
                            <div class="input-group-addon">.</div>
                            <input type="text" class="form-control" id="net_d" runat="server">
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="gw_a" class="control-label col-md-2 col-md-offset-1 col-xs-2 col-xs-offset-1">Gw :</label>
                        <div class="input-group col-md-8 col-xs-8">
                            <input type="text" class="form-control" id="gw_a" runat="server">
                            <div class="input-group-addon">.</div>
                            <input type="text" class="form-control" id="gw_b" runat="server">
                            <div class="input-group-addon">.</div>
                            <input type="text" class="form-control" id="gw_c" runat="server">
                            <div class="input-group-addon">.</div>
                            <input type="text" class="form-control" id="gw_d" runat="server">
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:button runat="server" text="Refresh IP" CssClass="btn btn-default col-md-10 col-md-offset-1 col-xs-10 col-xs-offset-1" ID="btSubmit" OnClick="btSubmit_Click" />
                    </div>
                </div>
            </div>
            <div class="panel panel-default">
                <div class="panel-heading">IP Info</div>
                <textarea class="form-control panel-body" style="font-family:'Lucida Console'" rows="25" id="ip_info" runat="server"></textarea>
            </div>
        </form>
    </div>
</body>
