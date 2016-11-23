AvatarDB-SQLQuery
=================

This windows form application uses the WSAPI.RADplus.XML.XMLservice which is a Avatar web service that allows you to submit a SQL query to the Caché database. The SQL syntax complies with Caché SQL which is the InterSystems extension of SQL-92. This is a useful tool for testing SQL queries against your Avatar Caché database. This tool is particularly helpful during widget, reports, or any other reporting development so that you can get results from your widget instantly. The result may be viewed within a datagrid or the within the XML that is returned by the webservice. The XML is useful when you're debugging your query to see where something may have gone wrong as the full error message from the SOAP web service would be displayed here. NOTE: This has only been tested with InterSystems Caché 2010.2

SOFTWARE REQUIREMENTS:
* Avatar 2014 from Netsmart
* InterSystems Caché (2010)
* Installation and activation of Avatar web services API.
* Configure the web service reference so that it is connecting an Avatar database.

AUTHOR:
Barry Gaffey
  
DATE CREATED:
July 22nd, 2013
