<%@ page language="C#" autoeventwireup="true" codebehind="index.aspx.cs" inherits="ZebraPuma.Web.NetIPConfig.index" validaterequest="false" %>

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
                <div class="panel-heading" style="text-align: center">
                    <h1>
                        <asp:label runat="server" text="Label" id="NetIPConfigTitle"></asp:label>
                    </h1>
                </div>
            </div>
            <div class="panel panel-default">
                <div class="panel-heading">Operating System</div>
                <div class="panel-body">
                    <div class="form-group">
                        <div class="col-md-4 col-xs-4">
                            <img class="img-responsive center-block" runat="server" id="imgMacOSX" />
                        </div>
                        <div class="col-md-4 col-xs-4">
                            <img class="img-responsive center-block" runat="server" id="imgLinux" />
                        </div>
                        <div class="col-md-4 col-xs-4">
                            <img class="img-responsive center-block" runat="server" id="imgWindows" />
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
                        <asp:button runat="server" text="Refresh IP" cssclass="btn btn-default col-md-10 col-md-offset-1 col-xs-10 col-xs-offset-1" id="btSubmit" onclick="btSubmit_Click" />
                    </div>
                </div>
            </div>
            <div class="panel panel-default">
                <div class="panel-heading">IP Info</div>
                <textarea class="form-control panel-body" style="font-family: monospace; font-size: 10px; background-color: white;" rows="15" id="ip_info" runat="server" readonly="readonly"></textarea>
            </div>
        </form>
    </div>
</body>
