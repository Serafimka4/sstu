<?xml version="1.0"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version='1.0'>
	<xsl:template match="/">
		<html>
			<head>
				<link rel="stylesheet" type="text/css" href="stylesheet.css" />
			</head>
			<body>
				<h1>My Favorite People</h1>
				<table>
					<tr class="caption">
						<td>ID</td>
						<td>Name</td>
						<td>Address</td>
						<td>Telephone</td>
						<td>Fax</td>
						<td>E-Mail</td>
					</tr>
					<xsl:for-each select="people/person[id='E02']">
						<tr>
							<td><xsl:value-of select="id"/></td>
							<td><xsl:value-of select="name"/></td>
							<td><xsl:value-of select="address"/></td>
							<td><xsl:value-of select="telephone"/></td>
							<td><xsl:value-of select="fax"/></td>
							<td><xsl:value-of select="email"/></td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet> 
