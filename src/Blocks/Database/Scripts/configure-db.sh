sleep 15
/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P pass@1234 -d master -i setup.sql
