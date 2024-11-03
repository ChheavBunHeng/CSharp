import { Accordion, AccordionSummary, AccordionDetails, Typography } from "@mui/material";
import ExpandMoreIcon from "@mui/icons-material/ExpandMore";

export default function Careers() {
    const jobs = [
        {
            title: "Electrical Engineer",
            description: "Design and develop electrical systems for automotive applications in Cambodia.",
            details: "As an Electrical Engineer, you'll work with a local team to create innovative electrical designs and ensure product quality.",
            requirements: [
                "Bachelor's degree in Electrical Engineering or related field.",
                "Experience with electrical design software.",
                "Strong problem-solving skills.",
                "Excellent communication and teamwork abilities."
            ]
        },
        {
            title: "Production Supervisor",
            description: "Oversee manufacturing operations and lead production teams in Cambodia.",
            details: "The Production Supervisor will manage daily production schedules and ensure quality standards are met while leading a local team.",
            requirements: [
                "Proven experience as a Production Supervisor.",
                "Strong knowledge of production processes and machinery.",
                "Excellent leadership and organizational skills.",
                "Ability to work under pressure and meet deadlines."
            ]
        },
        {
            title: "Quality Assurance Analyst",
            description: "Ensure the quality of our products through rigorous testing in Cambodia.",
            details: "Conduct manual and automated testing, analyze results, and report defects to maintain high product quality.",
            requirements: [
                "Bachelor's degree in Computer Science or related field.",
                "Experience with QA methodologies and testing tools.",
                "Strong analytical and troubleshooting skills.",
                "Attention to detail and excellent communication."
            ]
        },
        {
            title: "Human Resources Manager",
            description: "Manage employee relations and recruitment efforts in Cambodia.",
            details: "Responsible for developing HR strategies, overseeing recruitment, and ensuring employee satisfaction within the company.",
            requirements: [
                "Bachelor's degree in Human Resources or related field.",
                "Proven experience in HR management.",
                "Strong interpersonal and communication skills.",
                "Knowledge of labor laws and regulations."
            ]
        },
        {
            title: "Software Developer",
            description: "Develop and maintain software applications for internal use in Cambodia.",
            details: "As a Software Developer, you'll design, code, and test software solutions to improve operational efficiency.",
            requirements: [
                "Bachelor's degree in Computer Science or related field.",
                "Experience with JavaScript, React, and Node.js.",
                "Strong problem-solving skills and attention to detail.",
                "Ability to work collaboratively in a team."
            ]
        }
    ];

    return (
        
        <div className="p-4 max-w-[90%] mx-auto">
        <div className="w-full h-[300px] bg-cover bg-center relative" style={{ backgroundImage: 'url("https://images.unsplash.com/photo-1517694712202-14dd9538aa97?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80")' }}>
    <div className="absolute inset-0 bg-black opacity-50"></div>
    <div className="absolute inset-0 flex justify-center items-center text-white">
        <Typography variant="h3" className="font-bold text-center">
            Discover Your Dream Job!
        </Typography>
    </div>
    </div>
        <div>

            <Typography variant="h4" align="center" gutterBottom>
                Careers at SCWS
            </Typography>
            <Typography variant="subtitle1" align="center" paragraph>
                Join our dynamic team and contribute to innovative automotive solutions in Cambodia!
            </Typography>
            {jobs.map((job, index) => (
                <Accordion key={index} className="mb-2" elevation={3}>
                    <AccordionSummary expandIcon={<ExpandMoreIcon />} aria-controls={`panel${index}-content`} id={`panel${index}-header`}>
                        <div className="flex justify-between items-center w-full">
                            <Typography className="font-bold">{job.title}</Typography>
                        </div>
                    </AccordionSummary>
                    <AccordionDetails className="flex flex-col w-full">
                        <Typography className="mb-1">{job.details}</Typography>
                        <Typography variant="subtitle2" className="font-semibold mb-1">
                            Requirements:
                        </Typography>
                        <ul className="list-disc pl-5 mb-2">
                            {job.requirements.map((requirement, reqIndex) => (
                                <li key={reqIndex}>
                                    <Typography component="span" className="font-bold">{requirement.split(":")[0]}:</Typography> 
                                    {requirement.split(":").slice(1).join(":")}
                                </li>
                            ))}
                        </ul>
                    </AccordionDetails>
                </Accordion>
            ))}
        </div>
        </div>
    );
}
