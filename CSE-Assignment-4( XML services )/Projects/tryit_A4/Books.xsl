<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
    <xsl:template match="/">
      <html> <body>
          <h1>Books</h1>
          <table border = "1">
            <tr bgcolor = "yellow">
			  <td><b>Title</b></td>
              <td><b>Cover</b></td>
              <td><b>ISBN</b></td>
              <td><b>Author First Name</b></td>
			  <td><b>Author Last Name</b></td>
			  <td><b>Author Phone</b></td>
			  <td><b>Author Office</b></td>
			  <td><b>Publisher</b></td>
			  <td><b>Year</b></td>
			  <td><b>Edition</b></td>
            </tr>
            <xsl:for-each select="Books/Book">
				<xsl:sort select="Name" />
				<tr style="font-size: 10pt; font-family: verdana">
				  <td><xsl:value-of select="Title"/></td>
				  <td><xsl:value-of select="Title/@Cover"/></td>
				  <td><xsl:value-of select="Isbn"/></td>
				  <td><xsl:value-of select="Author/Name/First"/></td>
				  <td><xsl:value-of select="Author/Name/Last"/></td>
				  <td><xsl:value-of select="Author/Contact/Phone"/></td>
				  <td><xsl:value-of select="Author/Contact/@Office"/></td>
				  <td><xsl:value-of select="Publisher"/></td>
				  <td><xsl:value-of select="Year"/></td>
				  <td><xsl:value-of select="Year/@edition"/></td>
				</tr>
            </xsl:for-each>
          </table>
        </body>
      </html>
    </xsl:template>
</xsl:stylesheet>