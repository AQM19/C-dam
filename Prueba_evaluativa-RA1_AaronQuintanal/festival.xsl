<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="text"/>
	<xsl:variable name="newline" select="'&#10;'"/>
	<xsl:template match="/">
		<xsl:text>Número de actuación,escenario,día,hora</xsl:text>
		<xsl:value-of select="$newline"/>
		<xsl:for-each select="//actuacion">
			<xsl:value-of select="@numero"/>
			<xsl:text>,</xsl:text>
			<xsl:value-of select="escenario"/>
			<xsl:text>,</xsl:text>
			<xsl:value-of select="fecha"/>
			<xsl:text>,</xsl:text>
			<xsl:value-of select="hora"/>
			<xsl:value-of select="$newline"/>
		</xsl:for-each>
	</xsl:template>
</xsl:stylesheet>