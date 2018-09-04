AvatarDB-SQLQuery
=================

This windows form application uses the WSAPI.RADplus.XML.XMLservice, which, is an Avatar web service that allows you to submit a SQL query to the Caché database. The SQL syntax complies with Caché SQL, which, is the InterSystems extension of SQL-92. This is a useful tool for testing SQL queries against your Avatar Caché database. This tool is particularly helpful during widget, reports, or any other reporting development so that you can get results from your widget instantly. Viewing query results using this app is faster than formally submitting the query in a widget within Avatar and then navigating back to a view that contains widget. The query result may be viewed within a datagrid or within the XML that is returned by the webservice. The XML is useful when you're debugging your query because you can see where something may have gone wrong as the full error message from the SOAP web service would be displayed here. NOTE: This application has only been tested with InterSystems Caché 2010.2

SOFTWARE REQUIREMENTS:
* Avatar 2014 from Netsmart
* InterSystems Caché (2010)
* Installation and activation of Avatar web services API.
* Configure the web service reference so that it is connecting an Avatar database.
* The proxy class for XMLService was not included, you should regenerate this proxy class in your own environment by pointing it to where this web service is hosted in your environment.

AUTHOR:
Barry Gaffey
  
DATE CREATED:
July 22nd, 2013
