First it would be necessary to have GCP project available. 
So check for this link: https://cloud.google.com/?hl=pt-br

Then we will need to turn on compute engine api on GCP project. 
Use this link :https://console.cloud.google.com/flows/enableapi?apiid=compute.googleapis.com&hl=pt-br&_ga=2.114873799.1195574534.1674226617-401781366.1674226617&_gac=1.47542741.1674226727.Cj0KCQiAlKmeBhCkARIsAHy7WVuP4KSJPnSZ4al14jY-TazK72yv-34DQsfWP4uX7GGY6JLXN1Q21coaAozyEALw_wcB

Besides of that we should create a file on cloud sheel, you can fide a console picture above on the rigth,
then type this on cloud shell: nano main.tf

Copy and Paste the code inside main.tf 

Save the file

Now you will need to create an other file: terraform.tfvars

Copy and Paste terraform.tfvars for your file. 

I suggest you to go on this site and tak guuid for the name of the bucket: 
https://www.uuidgenerator.net/

then paste on the var name of the bucket.

Save the file

Run: terraform init

Run: terraform plan

Run on cloud shell: terraform apply

Answer: Yes

Install dotnet : 

Run to intall google cloud functions and create a function: gcloud functions deploy teste --entry-point Program.cs --runtime dotnet6 --trigger-http 

Answer 3x times: Yes

Run: gcloud services enable cloudscheduler.googleapis.com

