<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="505.aspx.cs" Inherits="CustomErrorPages._505" %>
<%@ Import Namespace="System.Net" %>

<%
    // Override status code, because customErrors set it to 200
    Response.Clear();
    Response.StatusCode = (int)HttpStatusCode.NotFound;
%>

<!DOCTYPE html>

<html>
    <head>
        <title>404</title>
    </head>
    <body>
        Custom 404 page
    </body>
</html>
