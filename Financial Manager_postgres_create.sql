CREATE TABLE "User" (
	"Id" serial NOT NULL,
	"Name" varchar(255) NOT NULL,
	"Surname" varchar(255) NOT NULL,
	"Occupation" VARCHAR(255),
	"Photo" BINARY,
	"Default Currency" integer NOT NULL,
	"Default Language" integer NOT NULL,
	"Username" VARCHAR(255) NOT NULL UNIQUE,
	"Password" VARCHAR(255) NOT NULL,
	"Salt" VARCHAR(255) NOT NULL,
	CONSTRAINT "User_pk" PRIMARY KEY ("Id")
) WITH (
  OIDS=FALSE
);



CREATE TABLE "Currency" (
	"Code" integer NOT NULL,
	"Letter Code" varchar(3) NOT NULL UNIQUE,
	"Name" varchar(255) NOT NULL UNIQUE,
	"Sign" varchar(1) NOT NULL UNIQUE,
	CONSTRAINT "Currency_pk" PRIMARY KEY ("Code")
) WITH (
  OIDS=FALSE
);



CREATE TABLE "Currency Converter" (
	"From" integer NOT NULL,
	"To" integer NOT NULL,
	"Price" DECIMAL NOT NULL,
	CONSTRAINT "Currency Converter_pk" PRIMARY KEY ("From","To")
) WITH (
  OIDS=FALSE
);



CREATE TABLE "Transaction" (
	"Id" serial NOT NULL,
	"Categoty" integer NOT NULL,
	"Amount" DECIMAL NOT NULL,
	"Currency" integer NOT NULL,
	"User" integer NOT NULL,
	"Is_spending" BOOLEAN NOT NULL,
	"Period" integer,
	"Remark" VARCHAR(255),
	"Date" DATE NOT NULL,
	"Is_planned" BOOLEAN NOT NULL,
	CONSTRAINT "Transaction_pk" PRIMARY KEY ("Id")
) WITH (
  OIDS=FALSE
);



CREATE TABLE "Category" (
	"id" serial NOT NULL,
	"Name" varchar(255) NOT NULL UNIQUE,
	"Is spending" BOOLEAN NOT NULL,
	"Is income" BOOLEAN NOT NULL,
	"Icon" BINARY,
	CONSTRAINT "Category_pk" PRIMARY KEY ("id")
) WITH (
  OIDS=FALSE
);



CREATE TABLE "Payment Period" (
	"Id" serial NOT NULL,
	"Name" varchar(255) NOT NULL UNIQUE,
	"Period (days)" integer NOT NULL,
	CONSTRAINT "Payment Period_pk" PRIMARY KEY ("Id")
) WITH (
  OIDS=FALSE
);



CREATE TABLE "Language" (
	"Id" integer NOT NULL,
	"Name" VARCHAR(255) NOT NULL,
	CONSTRAINT "Language_pk" PRIMARY KEY ("Id")
) WITH (
  OIDS=FALSE
);



ALTER TABLE "User" ADD CONSTRAINT "User_fk0" FOREIGN KEY ("Default Currency") REFERENCES "Currency"("Code");
ALTER TABLE "User" ADD CONSTRAINT "User_fk1" FOREIGN KEY ("Default Language") REFERENCES "Language"("Id");


ALTER TABLE "Currency Converter" ADD CONSTRAINT "Currency Converter_fk0" FOREIGN KEY ("From") REFERENCES "Currency"("Code");
ALTER TABLE "Currency Converter" ADD CONSTRAINT "Currency Converter_fk1" FOREIGN KEY ("To") REFERENCES "Currency"("Code");

ALTER TABLE "Transaction" ADD CONSTRAINT "Transaction_fk0" FOREIGN KEY ("Categoty") REFERENCES "Category"("id");
ALTER TABLE "Transaction" ADD CONSTRAINT "Transaction_fk1" FOREIGN KEY ("Currency") REFERENCES "Currency"("Code");
ALTER TABLE "Transaction" ADD CONSTRAINT "Transaction_fk2" FOREIGN KEY ("User") REFERENCES "User"("Id");
ALTER TABLE "Transaction" ADD CONSTRAINT "Transaction_fk3" FOREIGN KEY ("Period") REFERENCES "Payment Period"("Id");




