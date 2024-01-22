FROM mcr.microsoft.com/mssql/server:2019-latest


USER root
COPY ./Blocks/Database/Scripts /
# Grant permissions for to our scripts to be executable

RUN chmod +x ./configure-db.sh
RUN chmod +x ./entrypoint.sh

CMD /bin/bash ./entrypoint.sh
#ENTRYPOINT ["./entrypoint.sh"]