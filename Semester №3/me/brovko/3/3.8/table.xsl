<?xml version="1.0"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version='1.0'>
	<xsl:template match="/">
		<html>
			<body>
				<h1>My University</h1>
				<table>
					<tr>
						<td>Class (Аудитория)</td>
						<td>Student count (Количество студентов)</td>
						<td>Present count (Количество присутствующих)</td>
						<td>Section count (Количество групп)</td>
					</tr>
					<xsl:apply-templates select="table/class" />
				</table>
			</body>
		</html>
	</xsl:template>

	<xsl:template match='table/class'>
		<tr>
			<td>
				<xsl:value-of select="@id" />

				<span>
					<xsl:if test="@id = 1">st</xsl:if>
					<xsl:if test="@id = 2">nd</xsl:if>
					<xsl:if test="@id = 3">rd</xsl:if>
					<xsl:if test="@id &gt; 3">th</xsl:if>
				</span>
			</td>
			<td><xsl:value-of select="studentCount"/></td>
			<td><xsl:value-of select="presentCount"/></td>
			<td><xsl:value-of select="sectionCount"/></td>
		</tr>
	</xsl:template>
</xsl:stylesheet>
