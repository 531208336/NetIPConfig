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
        <form class="form-horizontal col-md-6 col-md-offset-3">
            <div class="panel panel-default">
                <div class="panel-heading"style="text-align:center"><h1>SkypeBox</h1></div>
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
                        <label for="ip-a" class="control-label col-md-2 col-md-offset-1 col-xs-2 col-xs-offset-1">IP :</label>
                        <div class="input-group col-md-8 col-xs-8">
                            <input type="text" class="form-control" id="ip-a">
                            <div class="input-group-addon">.</div>
                            <input type="text" class="form-control" id="ip-b">
                            <div class="input-group-addon">.</div>
                            <input type="text" class="form-control" id="ip-c">
                            <div class="input-group-addon">.</div>
                            <input type="text" class="form-control" id="ip-d">
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="net-a" class="control-label col-md-2 col-md-offset-1 col-xs-2 col-xs-offset-1">Net :</label>
                        <div class="input-group col-md-8 col-xs-8">
                            <input type="text" class="form-control" id="net-a">
                            <div class="input-group-addon">.</div>
                            <input type="text" class="form-control" id="net-b">
                            <div class="input-group-addon">.</div>
                            <input type="text" class="form-control" id="net-c">
                            <div class="input-group-addon">.</div>
                            <input type="text" class="form-control" id="net-d">
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="gw-a" class="control-label col-md-2 col-md-offset-1 col-xs-2 col-xs-offset-1">Gw :</label>
                        <div class="input-group col-md-8 col-xs-8">
                            <input type="text" class="form-control" id="gw-a">
                            <div class="input-group-addon">.</div>
                            <input type="text" class="form-control" id="gw-b">
                            <div class="input-group-addon">.</div>
                            <input type="text" class="form-control" id="gw-c">
                            <div class="input-group-addon">.</div>
                            <input type="text" class="form-control" id="gw-d">
                        </div>
                    </div>
                    <div class="form-group">
                        <button type="submit" class="btn btn-default col-md-10 col-md-offset-1 col-xs-10 col-xs-offset-1">Refresh IP</button>
                    </div>
                </div>
            </div>
            <div class="panel panel-default">
                <div class="panel-heading">IP Info</div>
                <textarea class="form-control " panel-body"" rows="20" id="ip-info"></textarea>
            </div>
        </form>
    </div>
</body>
