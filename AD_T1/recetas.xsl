<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="text"/>
	<xsl:variable name="newline" select="'&#10;'"/>
	<xsl:template match="/">
		<xsl:text>Nombre,Tipo,Dificultad,Calorías,Tiempo</xsl:text>
		<xsl:value-of select="$newline"/>
		<xsl:for-each select="//receta">
			<xsl:value-of select="nombre"/>
			<xsl:text>,</xsl:text>
			<xsl:value-of select="tipo/@definicion"/>
			<xsl:text>,</xsl:text>
			<xsl:value-of select="dificultad"/>
			<xsl:text>,</xsl:text>
			<xsl:value-of select="calorias"/>
			<xsl:text>,</xsl:text>
			<xsl:value-of select="tiempo"/>
			<xsl:value-of select="$newline"/>
		</xsl:for-each>
	</xsl:template>
</xsl:stylesheet>