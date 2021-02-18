# PLSQL_Crack_Pass
### Oralce 数据库连接工具 PLSQL Developer 保存在本地的密码抓取

1、获取 user.prefs 文件所在的位置

`for /r c: %a in (*user.prefs) do @echo %a`

![images](https://github.com/TryA9ain/PLSQL_Crack_Pass/blob/master/1.png)

2、使用工具破解保存在本地的密码

`PLSQLCrackPass.exe -p user.prefs_Path`

解密后的结果为：<username>/<password>@<server>

![images](https://github.com/TryA9ain/PLSQL_Crack_Pass/blob/master/1.png)
