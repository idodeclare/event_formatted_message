# FormattedMessage differences between 4.5.1 and 4.6

* Used vancem's instructions on the following page to trace to an ETL file and to report to a text file: http://blogs.msdn.com/b/vancem/archive/2012/12/21/using-tracesource-to-log-etw-data-to-a-file.aspx
* Decorated an Event method with the following Message: "Thread:{0} TranslateToManifestConvention escaped chars (leave off \\\\r, \\\\n): % & < > ' \\" \\t"

## .NET 4.5.1
* FormattedMessage is reported as "Thread:1 TranslateToManifestConvention escaped chars (leave off \r, \n): % &amp;amp; &amp;lt; &amp;gt; &amp;apos; &amp;quot;  " [sic]
* "\t" has become " "
* "%"  is "%"

## .NET 4.6.0
* FormattedMessage is reported as ""Thread:1 TranslateToManifestConvention escaped chars (leave off \r, \n): %% &amp;amp; &amp;lt; &amp;gt; &amp;apos; &amp;quot; %t" [sic]
* "\t" has become "%t"
* "%"  is "%%"
