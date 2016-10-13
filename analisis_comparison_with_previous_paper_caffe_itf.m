clc
close 
% Create some data
la = {'Car','Drink','Feed','Turn left','Turn right','Pet','Ball','Shake','Sniff','Walk'};
eb = 0:9;
linear          = [0.80 0.89 0.54 0.73 0.41 0.52 0.74 0.80 0.76 0.81];
rbf             = [0.78 0.89 0.51 0.74 0.40 0.50 0.74 0.81 0.76 0.82];
previous_week   = [0.78 0.90 0.53 0.72 0.41 0.47 0.74 0.78 0.75 0.80];
paper           = [0.83 0.83 0.71 0.60 0.48 0.52 0.75 0.88 0.85 0.79];

% paper = [0.75 0.88 0.58 0.60 0.37 0.30 0.73 0.79 0.74 0.66];

figure
semilogy(eb, linear, '-o')
hold on
semilogy(eb, rbf, '-o')
hold on
semilogy(eb, previous_week, '-o')
hold on
semilogy(eb, paper,'-o')


legend('with parameter selection - linear kernel (71.5472)','with parameter selection - rbf kernel (71.2642)','without parameter selection - linear kernel (70.3679)','paper (74.4704)');

set(gca, 'XTick', 0:9)
set(gca, 'XTickLabel', la)
% Turn on the grid
grid off

title('Parameter selection comparison in Caffe+ITF features');
xlabel('Class Activity');
ylabel('Accuracy');