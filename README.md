# PLSQL_Crack_Pass
Oralce 数据库连接工具 PLSQL Developer 保存在本地的密码抓取
1、获取 user.prefs 文件所在的位置
`for /r c: %a in (*user.prefs) do @echo %a`
2、使用工具破解保存在本地的密码
`PLSQLCrackPass.exe -p user.prefs_Path`
