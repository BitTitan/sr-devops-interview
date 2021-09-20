# MigrationWiz DevOps Challenge

## Preface

This challenge is meant to see how you would approach a problem and not to see
how well you deliver a solution that we think is right. You should not focus on
getting _the_ "right" answer.

- The **#Instructions** below are general steps to get you started.

- The **#Questions** section has short-response questions to answer.

  For each question, you can answer it inline directly in the README.md in your forked repo.

- The **#Challenges** section has more open-ended problems for you to solve in
  any way you see fit.

  For each challenge listed below, you can propose your approach, it's always a
  bonus if you can execute your proposal. Some challenges are posted as open-ended
  questions and you can answer them inline.

  The challenges are estimated to take between **2 - 8 hours** depending on how familiar
  you are with containerization technology. Research time is also accounted for in the
  estimated duration.

## Instructions

1. Download this repo and, using this one as the base, create a new **private** repo.
2. Provide your answers in your generated repo.
3. During the interview we will go over your answers.

## Questions

### 1. What even is DevOps?

DevOps can mean different things depending on the company you work for or who you talk to.
At BitTitan, we believe that "**Principles and Mindset > Practices > Tools**".

- What is your take on the definition of DevOps?

- Why has DevOps gained so much prominence recently?

### 2. Weapons of choice

There are so many tools available to us DevOps folks that it can be hard to keep up with all of them. Help us understand the weapons you choose to wield inside or outside of work.

- What is your primary OS?

- What shell do you use most often?

- Which scripting language(s) are you comfortable using? Which one is your favorite and why?

- Which programming language(s) are you comfortable using? Which one is your favorite and why?

- Which cloud provider(s) have you had experience with and what have you used them for?

- Name a few tools/applications that you use and describe their purpose in your work.

## Repo structure

This is a simple .NET console app that prints out the current time.

**In this repo, you will find:**

- [./Windows-Docker-App](./Windows-Docker-App):

  - .NET C# application that will tell time

 - [./EXEC](./EXEC):

   - Executable of C# application 

## Challenges (Optional) - Any number of these questions may be answered!

The following challenges are related to the repo. To provide your take on the
challenges, remember to commit your answers to your **private** repo.

### A. Can we Containerize this executable?

We have heard good things about containerization technology, and think what if
we bring in to our application stack. Can you help Containerize the the Windows .NET C# Windows App?

We have provided a basic `Dockerfile` to help you get started.

A compiled version of the app is available in the EXEC folder for easibility.

1. What are the steps needed to containerize this executable?
2. Are there better ways in Azure to scale this executable?
3. Provide an example of your working Dockerfile

### B. Create an Infrastructure Diagram for these services

Development requirement is as follows:

1.  **1 frontEnd service**
2.  **1 backend service**
3.  **1 data tier**

For this question provide an infrastucture diagram with your tools\Cloud resources of choice.  Choose any modern tech stack!

- Lastly, provide scenarios where dev requirments for these services are not sufficient.  Imagine yourself in a project review meeting where you provide recommendations improving the initial architecture. 

- What questions would you ask?

- Be creative!
