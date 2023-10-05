<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="html" />
	<xsl:template match="/">
		<HTML>
			<xsl:apply-templates />
		</HTML>
	</xsl:template>
	<xsl:template match="departamentos">
		<head>
			<title>LISTADO DE DEPARTAMENTOS</title>
		</head>
		<body>
			<h1>LISTADO DE DEPARTAMENTOS</h1>
			<table>
				<tr>
					<th>Numero</th>
					<th>Nombre</th>
					<th>Localidad</th>
				</tr>
				<xsl:apply-templates select="departamento"></xsl:apply-templates>
			</table>
		</body>
	</xsl:template>
	<xsl:template match="departamento">
		<tr>
			<xsl:apply-templates/>
		</tr>
	</xsl:template>
	<xsl:template match="numero">
		<td>
			<xsl:value-of select="."/>
		</td>
	</xsl:template>
	<xsl:template match="nombre">
		<td>
			<xsl:value-of select="."/>
		</td>
	</xsl:template>
	<xsl:template match="localidad">
		<td>
			<xsl:value-of select="."/>
		</td>
	</xsl:template>
	<xsl:template match="empleados">
	</xsl:template>
</xsl:stylesheet>