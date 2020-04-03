<?xml version="1.0"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version='1.0'>
	<xsl:template match="/">
		<html>
			<body>
				<h1>My Favorite People</h1>
				<xsl:apply-templates select="people/person"/>
			</body>
		</html>
	</xsl:template>
	<xsl:template match="people/person">
		<html>
			<body>
				<p>
					Title: <xsl:value-of select="id"/>
					<br />
					Name: <xsl:value-of select="name"/>
				</p>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
